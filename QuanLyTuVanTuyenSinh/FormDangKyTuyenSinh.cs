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

        private void btnDangKyTs_Click(object sender, EventArgs e)
        {
            if (Session.RoleID != 2 || cbbChonSinhVien.SelectedValue == null) return;

            int selectedID = (int)cbbChonSinhVien.SelectedValue;
            var student = db.StudentInfos.FirstOrDefault(s => s.InfoID == selectedID);
            if (student == null)
            {
                DialogResult result = MessageBox.Show("Sinh viên chưa có thông tin cá nhân. Bạn có muốn điền thông tin ngay?", "Thiếu thông tin", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
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
                }
            }

            if (cbbChonCoSo.SelectedItem == null || cbbChonNganh.SelectedItem == null ||
                (Session.RoleID == 2 && cbbChonSinhVien.SelectedItem == null))
            {
                MessageBox.Show("Vui lòng chọn đầy đủ thông tin cơ sở, ngành học (và sinh viên nếu là phụ huynh).", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int studentInfoId;
            int studentId;
            int majorId = (int)cbbChonNganh.SelectedValue;
            decimal? diemThi = null;
            decimal temp;
            if (decimal.TryParse(tbDiemThi.Text, out temp)) diemThi = temp;

            if (Session.RoleID == 3) // Sinh viên
            {
                studentId = db.StudentInfos.FirstOrDefault(s => s.StudentUserID == Session.UserID)?.InfoID ?? 0;
                studentInfoId = db.StudentInfos
           .Where(s => s.StudentUserID == Session.UserID)
           .Select(s => s.InfoID)
           .FirstOrDefault();
            }
            else // Phụ huynh
            {
                if (cbbChonSinhVien.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn sinh viên để đăng ký.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                studentInfoId = (int)cbbChonSinhVien.SelectedValue;
                studentId = (int)cbbChonSinhVien.SelectedValue;

            }

            if (studentId == 0)
            {
                MessageBox.Show("Không tìm thấy thông tin sinh viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra đã đăng ký chưa
            var daDangKy = db.AdmissionRecords.Any(r => r.StudentInfoID == studentInfoId);
            if (daDangKy)
            {
                MessageBox.Show("Sinh viên này đã đăng ký tuyển sinh rồi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            AdmissionRecord record = new AdmissionRecord
            {
                StudentInfoID = studentId,
                MajorID = majorId,
                ExamScore = diemThi,
                ResultStatus = 0,
                RegistrationDate = DateTime.Now,
                ParentUserID = Session.RoleID == 2 ? (int?)Session.UserID : null
            };

            db.AdmissionRecords.InsertOnSubmit(record);
            db.SubmitChanges();
            MessageBox.Show("Đăng ký tuyển sinh thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
