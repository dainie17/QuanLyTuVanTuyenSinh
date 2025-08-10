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

namespace QuanLyTuVanTuyenSinh
{
    public partial class FormQuanLySinhVien : Form
    {
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        public FormQuanLySinhVien()
        {
            InitializeComponent();
        }

        private void FormQuanLySinhVien_Load(object sender, EventArgs e)
        {
            LoadSinhVienCuaPhuHuynh();
        }

        private void LoadSinhVienCuaPhuHuynh()
        {
            using (var db = new QL_Tuyen_SinhDataContext())
            {
                var danhSachSinhVien = from s in db.StudentInfos
                                       join u in db.Users on s.StudentUserID equals u.UserID
                                       where s.ParentUserID == Session.UserID
                                       select new
                                       {
                                           u.UserID,
                                           s.FullName,
                                           u.Email,
                                           u.Phone,
                                           Gender = s.Gender.HasValue
                                ? (s.Gender.Value ? "Nam" : "Nữ")
                                : "Chưa xác định",
                                           s.BirthDate,
                                           s.Address
                                       };

                dtgSinhVien.DataSource = danhSachSinhVien.ToList();
                AddDeleteButtonColumn();
            }
        }

        private void DeleteStudentCascade(int studentUserId)
        {
            using (var db = new QL_Tuyen_SinhDataContext())
            {
                // Xác định đúng StudentInfo thuộc phụ huynh hiện tại
                var st = db.StudentInfos.SingleOrDefault(s =>
                    s.StudentUserID == studentUserId && s.ParentUserID == Session.UserID);

                if (st == null) return;

                // Lấy các hồ sơ tuyển sinh của sinh viên
                var records = db.AdmissionRecords.Where(r => r.StudentInfoID == st.InfoID).ToList();

                if (records.Any())
                {
                    var recordIds = records.Select(r => r.RecordID).ToList();

                    // Xoá Payments trước
                    var payments = db.Payments.Where(p => recordIds.Contains(p.RecordID));
                    db.Payments.DeleteAllOnSubmit(payments);

                    // Xoá AdmissionRecords
                    db.AdmissionRecords.DeleteAllOnSubmit(records);
                }

                // Xoá StudentInfo
                db.StudentInfos.DeleteOnSubmit(st);

                // Xoá luôn tài khoản User của sinh viên
                var user = db.Users.SingleOrDefault(u => u.UserID == studentUserId);
                if (user != null) db.Users.DeleteOnSubmit(user);

                db.SubmitChanges();
            }
        }


        private void dtgSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dtgSinhVien.Columns[e.ColumnIndex].Name == "colDelete")
            {
                int userId = (int)dtgSinhVien.Rows[e.RowIndex].Cells["UserID"].Value;
                string hoTen = dtgSinhVien.Rows[e.RowIndex].Cells["FullName"].Value?.ToString() ?? "";

                var confirm = MessageBox.Show(
                    $"Bạn có chắc muốn xoá sinh viên \"{hoTen}\"?\n" +
                    "Tất cả hồ sơ tuyển sinh và thanh toán liên quan cũng sẽ bị xoá.",
                    "Xác nhận xoá",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        DeleteStudentCascade(userId);
                        LoadSinhVienCuaPhuHuynh();
                        MessageBox.Show("Đã xoá sinh viên và toàn bộ dữ liệu liên quan.", "Thành công",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Xoá thất bại: " + ex.Message, "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void dtgSinhVien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int userId = (int)dtgSinhVien.Rows[e.RowIndex].Cells["UserID"].Value;
                FormSuaSinhVien frm = new FormSuaSinhVien(userId);
                frm.ShowDialog();
                LoadSinhVienCuaPhuHuynh(); // reload sau khi sửa
            }
        }

        private void AddDeleteButtonColumn()
        {
            if (dtgSinhVien.Columns["colDelete"] == null)
            {
                var btnCol = new DataGridViewButtonColumn
                {
                    Name = "colDelete",
                    HeaderText = "Xoá",
                    Text = "Xoá",
                    UseColumnTextForButtonValue = true,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                };
                dtgSinhVien.Columns.Add(btnCol);

            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormMain formMain = new FormMain();
            formMain.Show();
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            FormMain formMain = new FormMain();
            formMain.Show();
            this.Close();
        }

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
        }
    }
}
