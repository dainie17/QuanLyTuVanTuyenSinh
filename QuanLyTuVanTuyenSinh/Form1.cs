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
    public partial class Form1 : Form
    {
        private QL_Tuyen_SinhDataContext db = new QL_Tuyen_SinhDataContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbDangKy_Click(object sender, EventArgs e)
        {
            Form2 formDangKy = new Form2();
            formDangKy.Show();          // Mở form đăng ký
            this.Hide();                // Ẩn form hiện tại (nếu muốn)
        }

        private void tbTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            string username = tbTaiKhoan.Text.Trim();
            string password = tbMatKhau.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tài khoản và mật khẩu.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra thông tin đăng nhập
            var user = db.Users.FirstOrDefault(u =>
                u.UserName == username &&
                u.PasswordHash == password &&
                u.Status == 1);

            if (user == null)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Lưu session
            Session.UserID = user.UserID;
            Session.UserName = user.UserName;
            Session.RoleID = user.RoleID;

            // Chuyển sang MainForm
            FormMain formMain = new FormMain();
            formMain.Show();
            this.Hide();
        
        }
    }
}
