using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTuVanTuyenSinh
{
    public partial class FormMain : Form
    {
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
                    break;

                case 2: // Phụ huynh
                    btnDangKyTkSv.Visible = true;
                    btnQuanLySv.Visible = true;
                    btnDangKyTuyenSinh.Visible = true;
                    btnNganhHoc.Visible = true;
                    btnXemKetQua.Visible = true;
                    btnCapNhatTk.Visible = true;
                    break;

                case 3: // Sinh viên
                    btnDangKyTuyenSinh.Visible = true;
                    btnNganhHoc.Visible = true;
                    btnXemKetQua.Visible = true;
                    btnCapNhatTk.Visible = true;
                    break;
            }

            // Gợi ý: Hiển thị tên người dùng
            lblTenTruong.Text = $"Xin chào, {Session.UserName}";
        }

        private void btnQuanLyNganh_Click(object sender, EventArgs e)
        {
            FormQuanLyNganhHoc formQuanLyNganhHoc = new FormQuanLyNganhHoc();
            formQuanLyNganhHoc.FormClosed += (s, args) => this.Show();
            formQuanLyNganhHoc.Show();
            this.Hide();

        }

        private void btnCapNhatTk_Click(object sender, EventArgs e)
        {

        }

        private void btnQuanLyUser_Click(object sender, EventArgs e)
        {
            FormQuanLyUser formQuanLyUser = new FormQuanLyUser();
            formQuanLyUser.FormClosed += (s, args) => this.Show(); // Hiện lại form hiện tại khi FormQuanLyUser đóng
            formQuanLyUser.Show();
            this.Hide();
        }

        private void btnQuanLyCoSo_Click(object sender, EventArgs e)
        {
            FormQuanLyCoSo formQuanLyCo = new FormQuanLyCoSo();
            formQuanLyCo.FormClosed += (s, args) => this.Show(); // Hiện lại form hiện tại khi FormQuanLyUser đóng
            formQuanLyCo.Show();
            this.Hide();
        }

        private void btnQuanLyTuyenSinh_Click(object sender, EventArgs e)
        {
            FormFormQuanLyHoSo formFormQuanLyHoSo = new FormFormQuanLyHoSo();
            formFormQuanLyHoSo.FormClosed += (s, args) => this.Show();
            formFormQuanLyHoSo.Show();
            this.Hide();
        }
    }
}
