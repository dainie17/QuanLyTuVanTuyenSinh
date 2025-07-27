using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuanLyTuVanTuyenSinh
{
    public partial class FormMain : Form
    {
        private string username;
        private string password;
        private string email;
        private string phone;
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            // Xoá session
            Session.Clear();

            // Quay lại Form đăng nhập
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Close();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // Ẩn tất cả các nút mặc định trước
            btnQuanLyUser.Visible = false;
            btnQuanLyCoSo.Visible = false;
            btnQuanLyNganh.Visible = false;
            btnQuanLyTuyenSinh.Visible = false;
            btnDangKyTkSv.Visible = false;
            btnQuanLySv.Visible = false;
            btnDangKyTuyenSinh.Visible = false;
            btnNganhHoc.Visible = false;
            btnXemKetQua.Visible = false;
            btnCapNhatTk.Visible = false;
            btnDangXuat.Visible = true;

            // Hiển thị theo vai trò
            switch (Session.RoleID)
            {
                case 1: // Admin
                    btnQuanLyUser.Visible = true;
                    btnQuanLyCoSo.Visible = true;
                    btnQuanLyNganh.Visible = true;
                    btnQuanLyTuyenSinh.Visible = true;
                    btnDangXuat.Location = new Point(44, 225);
                    break;

                case 2: // Phụ huynh
                    btnDangKyTkSv.Visible = true;
                    btnDangKyTkSv.Location = new Point(44, 190);
                    btnQuanLySv.Visible = true;
                    btnQuanLySv.Location = new Point(44, 225);
                    btnDangKyTuyenSinh.Visible = true;
                    btnNganhHoc.Visible = true;
                    btnXemKetQua.Visible = true;
                    btnDangXuat.Location = new Point(44, 260);
                    break;

                case 3: // Sinh viên
                    btnDangKyTuyenSinh.Visible = true;
                    btnNganhHoc.Visible = true;
                    btnXemKetQua.Visible = true;
                    btnCapNhatTk.Visible = true;
                    btnDangXuat.Location = new Point(44, 225);
                    break;
            }

            // Gợi ý: Hiển thị tên người dùng
            lblTenTruong.Text = $"Xin chào, {Session.UserName}";
        }

        private void btnQuanLyNganh_Click(object sender, EventArgs e)
        {
            FormQuanLyNganhHoc formQuanLyNganhHoc = new FormQuanLyNganhHoc();
            formQuanLyNganhHoc.Show();
            this.Hide();

        }

        private void btnCapNhatTk_Click(object sender, EventArgs e)
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

        private void btnQuanLyUser_Click(object sender, EventArgs e)
        {
            FormQuanLyUser formQuanLyUser = new FormQuanLyUser();
            //formQuanLyUser.FormClosed += (s, args) => this.Show(); // Hiện lại form hiện tại khi FormQuanLyUser đóng
            formQuanLyUser.Show();
            this.Hide();
        }

        private void btnQuanLyCoSo_Click(object sender, EventArgs e)
        {
            FormQuanLyCoSo formQuanLyCo = new FormQuanLyCoSo();
            formQuanLyCo.Show();
            this.Hide();
        }

        private void btnQuanLyTuyenSinh_Click(object sender, EventArgs e)
        {
            FormFormQuanLyHoSo formFormQuanLyHoSo = new FormFormQuanLyHoSo();
            formFormQuanLyHoSo.Show();
            this.Hide();
        }

        private void btnNganhHoc_Click(object sender, EventArgs e)
        {
            FormXemNganhHoc formXemNganhHoc = new FormXemNganhHoc();
            formXemNganhHoc.Show();
            this.Hide();
        }

        private void btnDangKyTkSv_Click(object sender, EventArgs e)
        {
            FormTaoTaiKhoanSinhVien formTaoTaiKhoanSinhVien = new FormTaoTaiKhoanSinhVien();
            formTaoTaiKhoanSinhVien.Show();
            this.Hide();
        }

        private void btnDangKyTuyenSinh_Click(object sender, EventArgs e)
        {
            FormDangKyTuyenSinh formDangKyTuyenSinh = new FormDangKyTuyenSinh();
            formDangKyTuyenSinh.Show();
            this.Hide();
        }

        private void btnXemKetQua_Click(object sender, EventArgs e)
        {
            FormXemKetQua formXemKetQua = new FormXemKetQua();
            formXemKetQua.Show();
            this.Hide();
        }

        private void btnQuanLySv_Click(object sender, EventArgs e)
        {
            FormQuanLySinhVien formQuanLySinhVien = new FormQuanLySinhVien();
            formQuanLySinhVien.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            // Xoá session
            Session.Clear();

            this.Close();
        }
    }
}
