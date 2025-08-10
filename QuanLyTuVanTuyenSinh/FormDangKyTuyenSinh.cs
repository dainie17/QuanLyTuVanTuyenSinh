using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace QuanLyTuVanTuyenSinh
{
    public partial class FormDangKyTuyenSinh : Form
    {
        private QL_Tuyen_SinhDataContext db = new QL_Tuyen_SinhDataContext();
        private string username;
        private string password;
        private string email;
        private string phone;

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        public FormDangKyTuyenSinh()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            cbbChonCoSo.DataSource = db.Campus.ToList();
            cbbChonCoSo.DisplayMember = "CampusName";
            cbbChonCoSo.ValueMember = "CampusID";

            if (Session.RoleID == 3) // Sinh viên
            {
                groupBox1.Visible = false;
                cbbChonSinhVien.Visible = false;
                groupBox3.Location = new Point(66, 100);
                groupBox4.Location = new Point(66, 180);

                var student = db.StudentInfos.FirstOrDefault(s => s.StudentUserID == Session.UserID);
                if (student == null)
                {
                    btnDangKyTs.Text = "Điền thông tin ngay";
                    btnDangKyTs.Click -= btnDangKyTs_Click;
                    btnDangKyTs.Click += (s, e) =>
                    {
                        using (var db = new QL_Tuyen_SinhDataContext())
                        {
                            var currentUser = db.Users.FirstOrDefault(u => u.UserID == Session.UserID);

                            if (currentUser != null)
                            {
                                username = currentUser.UserName;
                                password = currentUser.PasswordHash;
                                email = currentUser.Email;
                                phone = currentUser.Phone;
                                // và các trường khác...
                            }
                        }
                        FormDienThongTinSinhVien formDienThongTinSinhVien = new FormDienThongTinSinhVien(username, password, email, phone);
                        formDienThongTinSinhVien.Show();
                        this.Hide();
                    };
                }
            }
            else if (Session.RoleID == 2) // Phụ huynh
            {
                cbbChonSinhVien.Visible = true;
                var list = db.StudentInfos.Where(x => x.ParentUserID == Session.UserID)
                              .Select(s => new { s.InfoID, s.FullName }).ToList();
                cbbChonSinhVien.DataSource = list;
                cbbChonSinhVien.DisplayMember = "FullName";
                cbbChonSinhVien.ValueMember = "InfoID";
            }

        }

        private void cbbChonCoSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbChonCoSo.SelectedValue is int campusId)
            {
                cbbChonNganh.DataSource = db.Majors
                    .Where(m => m.CampusID == campusId)
                    .ToList();
                cbbChonNganh.DisplayMember = "MajorName";
                cbbChonNganh.ValueMember = "MajorID";
            }

        }

        private void OpenDienThongTin()
        {
            using (var ctx = new QL_Tuyen_SinhDataContext())
            {
                var currentUser = ctx.Users.FirstOrDefault(u => u.UserID == Session.UserID);
                if (currentUser != null)
                {
                    username = currentUser.UserName;
                    password = currentUser.PasswordHash;
                    email = currentUser.Email;
                    phone = currentUser.Phone;
                }
            }
            var f = new FormDienThongTinSinhVien(username, password, email, phone);
            f.Show();
            this.Hide();
        }

        private void btnDangKyTs_Click(object sender, EventArgs e)
        {
            // Lấy sẵn majorId (nếu chọn được), điểm thi (nếu nhập đúng) 
            int majorId = 0;
            if (cbbChonNganh.SelectedValue is int mid) majorId = mid;

            decimal? diemThi = null;
            decimal diemTemp;
            if (decimal.TryParse(tbDiemThi.Text, out diemTemp)) diemThi = diemTemp;

            // ========== VAI TRÒ SINH VIÊN ==========
            if (Session.RoleID == 3)
            {
                // 1) Chưa có StudentInfo -> điều hướng sang form điền thông tin
                var student = db.StudentInfos.FirstOrDefault(s => s.StudentUserID == Session.UserID);
                if (student == null)
                {
                    OpenDienThongTin();
                    return;
                }

                // 2) Bỏ trống chọn ngành HOẶC bỏ trống điểm thi -> điều hướng
                if (majorId == 0 || string.IsNullOrWhiteSpace(tbDiemThi.Text))
                {
                    OpenDienThongTin();
                    return;
                }

                // 3) Nhập điểm <0 hoặc >10 -> điều hướng
                if (!diemThi.HasValue || diemThi.Value < 0m || diemThi.Value > 10m)
                {
                    OpenDienThongTin();
                    return;
                }

                // 4) Valid: tiếp tục đăng ký
                int studentInfoId = student.InfoID;

                // Không cho đăng ký trùng
                if (db.AdmissionRecords.Any(r => r.StudentInfoID == studentInfoId))
                {
                    MessageBox.Show("Sinh viên này đã đăng ký tuyển sinh rồi.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var newRecord = new AdmissionRecord
                {
                    StudentInfoID = studentInfoId,
                    MajorID = majorId,
                    ExamScore = diemThi,            // đã đảm bảo 0..10
                    ResultStatus = 0,
                    RegistrationDate = DateTime.Now,
                    ParentUserID = null
                };

                db.AdmissionRecords.InsertOnSubmit(newRecord);
                db.SubmitChanges();
                MessageBox.Show("Đăng ký tuyển sinh thành công.", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Chuyển về main form
                FormMain mainForm = new FormMain();
                mainForm.Show();
                this.Close();
                return;
            }

            // ========== VAI TRÒ PHỤ HUYNH ==========
            if (Session.RoleID == 2)
            {
                // Bắt buộc chọn cơ sở & ngành (điểm có thể bỏ trống)
                if (cbbChonCoSo.SelectedItem == null || majorId == 0)
                {
                    MessageBox.Show("Vui lòng chọn đầy đủ cơ sở và ngành học.", "Thiếu thông tin",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cbbChonSinhVien.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn sinh viên để đăng ký.", "Thiếu thông tin",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int studentInfoId = (int)cbbChonSinhVien.SelectedValue;
                int? parentId = Session.UserID;

                if (db.AdmissionRecords.Any(r => r.StudentInfoID == studentInfoId))
                {
                    MessageBox.Show("Sinh viên này đã đăng ký tuyển sinh rồi.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Điểm có thể null (bỏ trống) -> vẫn đăng ký thành công
                var newRecord = new AdmissionRecord
                {
                    StudentInfoID = studentInfoId,
                    MajorID = majorId,
                    ExamScore = diemThi,           // có thể null
                    ResultStatus = 0,
                    RegistrationDate = DateTime.Now,
                    ParentUserID = parentId
                };

                db.AdmissionRecords.InsertOnSubmit(newRecord);
                db.SubmitChanges();
                MessageBox.Show("Đăng ký tuyển sinh thành công.", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Chuyển về main form
                FormMain mainForm = new FormMain();
                mainForm.Show();
                this.Close();
                return;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            FormMain form = new FormMain();
            form.Show();
            this.Close();

        }

        private void cbbChonNganh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbChonNganh.SelectedValue is int majorId)
            {
                var major = db.Majors.FirstOrDefault(m => m.MajorID == majorId);
                if (major != null)
                {
                    tbMoTa.Text = major.Description;

                    if (!string.IsNullOrEmpty(major.ImagePath) && System.IO.File.Exists(major.ImagePath))
                    {
                        pbAnhNganh.Image = Image.FromFile(major.ImagePath);
                    }
                    else
                    {
                        pbAnhNganh.Image = null;
                    }
                }
            }
        }

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
        }
    }
}
