using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Runtime.InteropServices;

namespace QuanLyTuVanTuyenSinh
{
    public partial class FormSuaSinhVien : Form
    {
        private int _userId;
        private QL_Tuyen_SinhDataContext db;
        private User user;
        private StudentInfo student;
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        public FormSuaSinhVien(int userId)
        {
            InitializeComponent();
            _userId = userId;
            db = new QL_Tuyen_SinhDataContext();
        }

        private void FormSuaSinhVien_Load(object sender, EventArgs e)
        {
            // Lấy user và sinh viên
            user = db.Users.SingleOrDefault(u => u.UserID == _userId);
            student = db.StudentInfos.SingleOrDefault(s => s.StudentUserID == _userId);

            if (user == null || student == null)
            {
                MessageBox.Show("Không tìm thấy dữ liệu");
                this.Close();
                return;
            }

            // Hiển thị lên controls (ví dụ: TextBoxes, DatePicker, RadioButtons…)
            tbUserName.Text = user.UserName;
            tbEmail.Text = user.Email;
            tbPhone.Text = user.Phone;

            tbFullName.Text = student.FullName;
            dtpBirthDate.Value = student.BirthDate ?? DateTime.Now;
            tbAddress.Text = student.Address;
            if (student.Gender.HasValue)
            {
                rbNam.Checked = student.Gender.Value;
                rbNu.Checked = !student.Gender.Value;
            }
            else
            {
                rbNam.Checked = false;
                rbNu.Checked = false;
            }
            tbNationalID.Text = student.NationalID;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Validate nội dung trước khi lưu
            if (string.IsNullOrWhiteSpace(tbFullName.Text)
                || string.IsNullOrWhiteSpace(tbUserName.Text)
                || string.IsNullOrWhiteSpace(tbEmail.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ họ tên, tên đăng nhập và email.");
                return;
            }

            // Cập nhật user
            user.UserName = tbUserName.Text.Trim();
            user.Email = tbEmail.Text.Trim();
            user.Phone = tbPhone.Text.Trim();

            // Cập nhật student
            student.FullName = tbFullName.Text.Trim();
            student.BirthDate = dtpBirthDate.Value.Date;
            student.Address = tbAddress.Text.Trim();
            student.Gender = rbNam.Checked;
            student.NationalID = tbNationalID.Text.Trim();

            try
            {
                db.SubmitChanges();
                MessageBox.Show("Cập nhật thành công.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật: " + ex.Message);
            }
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void FormSuaSinhVien_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
        }
    }

}
