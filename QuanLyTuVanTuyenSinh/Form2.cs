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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string username = tbTenDangNhap.Text.Trim();
            string password = tbMatKhau.Text.Trim();
            string email = tbEmail.Text.Trim();
            string phone = tbSDT.Text.Trim();
            byte role = cbPhuHuynh.Checked ? (byte)2 : cbSinhVien.Checked ? (byte)3 : (byte)0;

            // 🔒 Kiểm tra dữ liệu
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(phone) || role == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin và chọn vai trò!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra định dạng email đơn giản
            if (!email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show("Email không hợp lệ!", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra số điện thoại chỉ gồm số
            if (!phone.All(char.IsDigit))
            {
                MessageBox.Show("Số điện thoại chỉ được chứa chữ số!", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (QL_Tuyen_SinhDataContext db = new QL_Tuyen_SinhDataContext())
            {
                // 🔎 Kiểm tra tên đăng nhập trùng
                bool userExists = db.Users.Any(u => u.UserName == username);
                if (userExists)
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại, vui lòng chọn tên khác!", "Trùng tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // ✅ Tạo người dùng mới
                User newUser = new User
                {
                    UserName = username,
                    PasswordHash = password, // Bạn nên hash nếu triển khai thực tế
                    Email = email,
                    Phone = phone,
                    Status = 1,
                    RoleID = role,
                    CreatedDate = DateTime.Now
                };

                db.Users.InsertOnSubmit(newUser);
                db.SubmitChanges(); // Ghi vào DB

                MessageBox.Show("Đăng ký thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Lưu dữ liệu đăng nhập
                Session.UserID = newUser.UserID;
                Session.UserName = newUser.UserName;
                Session.RoleID = newUser.RoleID;

                // ➡ Mở FormMain
                FormMain formMain = new FormMain();
                formMain.Show();
                this.Hide();
            }
        }

        private void tbMatKhau_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
