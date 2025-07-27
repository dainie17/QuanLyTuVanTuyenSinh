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

namespace QuanLyTuVanTuyenSinh
{
    
    public partial class FormDienThongTinSinhVien : Form
    {
        private string taiKhoan, Pass, Email, Sdt;

        public FormDienThongTinSinhVien(string username, string password, string email, string phone)
        {
            InitializeComponent();
            taiKhoan = username;
            Pass = password;
            Email = email;
            Sdt = phone;
            label6.Visible = false; label7.Visible = true;
            if (Session.RoleID == 3)
            {   
                label6.Visible = true; label7.Visible = false;
                btnTaoTaiKhoan.Text = "Cập nhật thông tin";
                this.Text = "Cập nhật thông tin sinh viên";

                using (var db = new QL_Tuyen_SinhDataContext())
                {
                    var student = db.StudentInfos.FirstOrDefault(s => s.StudentUserID == Session.UserID);
                    if (student != null)
                    {
                        tbTenSV.Text = student.FullName;
                        tbDiaChi.Text = student.Address;
                        tbCanCuocCongDan.Text = student.NationalID;
                        dtpNgaySinh.Value = student.BirthDate ?? DateTime.Now;
                        cbNam.Checked = student.Gender.HasValue;
                        cbNu.Checked = !student.Gender.HasValue;
                    }
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            FormTaoTaiKhoanSinhVien formTaoTaiKhoanSinhVien = new FormTaoTaiKhoanSinhVien();
            formTaoTaiKhoanSinhVien.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            FormMain form = new FormMain();
            form.Show();
            this.Close();
        }

        private void btnTaoTaiKhoan_Click(object sender, EventArgs e)
        {
            string fullname = tbTenSV.Text.Trim();
            string address = tbDiaChi.Text.Trim();
            string nationalID = tbCanCuocCongDan.Text.Trim();
            bool gender = cbNam.Checked;
            DateTime birthdate = dtpNgaySinh.Value;

            if (string.IsNullOrEmpty(fullname) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(nationalID))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin sinh viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var db = new QL_Tuyen_SinhDataContext())
            {
                if (Session.RoleID == 3)
                {
                    var student = db.StudentInfos.FirstOrDefault(s => s.StudentUserID == Session.UserID);
                    if (student != null)
                    {
                        // Cập nhật
                        student.FullName = fullname;
                        student.Address = address;
                        student.NationalID = nationalID;
                        student.BirthDate = birthdate;
                        student.Gender = gender;

                        db.SubmitChanges();
                        MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FormMain formMain = new FormMain();
                        formMain.Show();
                        this.Close();
                    }
                    else
                    {
                        // Thêm mới
                        var newStudent = new StudentInfo
                        {
                            StudentUserID = Session.UserID,
                            ParentUserID = null,
                            FullName = fullname,
                            Address = address,
                            NationalID = nationalID,
                            BirthDate = birthdate,
                            Gender = gender
                        };
                        db.StudentInfos.InsertOnSubmit(newStudent);
                        db.SubmitChanges();
                        MessageBox.Show("Thêm thông tin sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FormMain formMain = new FormMain();
                        formMain.Show();
                        this.Close();
                    }

                    
                }
                else
                {
                    // Trường hợp phụ huynh tạo mới sinh viên – giữ nguyên như trước
                    if (db.Users.Any(u => u.UserName == taiKhoan || u.Email == Email))
                    {
                        MessageBox.Show("Tên đăng nhập hoặc email đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var user = new User
                    {
                        UserName = taiKhoan,
                        PasswordHash = Pass,
                        Email = Email,
                        Phone = Sdt,
                        Status = 1,
                        RoleID = 3,
                        CreatedDate = DateTime.Now
                    };
                    db.Users.InsertOnSubmit(user);
                    db.SubmitChanges();

                    var student = new StudentInfo
                    {
                        StudentUserID = user.UserID,
                        ParentUserID = Session.UserID,
                        FullName = fullname,
                        Address = address,
                        NationalID = nationalID,
                        BirthDate = birthdate,
                        Gender = gender
                    };
                    db.StudentInfos.InsertOnSubmit(student);
                    db.SubmitChanges();

                    MessageBox.Show("Tạo tài khoản sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormMain formMain = new FormMain();
                    formMain.Show();
                    this.Close();
                }
            }
        }

    }
}
