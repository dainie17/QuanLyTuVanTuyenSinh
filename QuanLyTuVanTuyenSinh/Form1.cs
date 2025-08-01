﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace QuanLyTuVanTuyenSinh
{
    public partial class Form1 : Form
    {
        private QL_Tuyen_SinhDataContext db = new QL_Tuyen_SinhDataContext();

        //Khai báo API để có thể kéo thả vị trí giao diện
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
        }
    }
}
