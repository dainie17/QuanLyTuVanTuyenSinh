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
    public partial class FormQuanLyUser : Form
    {
        private QL_Tuyen_SinhDataContext dbContext;
        public FormQuanLyUser()
        {
            InitializeComponent();
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            dbContext = new QL_Tuyen_SinhDataContext();
            LoadUserData();
        }

        private void LoadUserData()
        {
            var users = dbContext.Users
                .Select(u => new
                {
                    u.UserID,
                    u.UserName,
                    u.Email,
                    u.Phone,
                    u.Status,
                    u.CreatedDate,
                    VaiTro = u.RoleID == 1 ? "Admin" : (u.RoleID == 2 ? "Phụ huynh" : "Sinh viên")
                }).ToList();

            dataGridView1.DataSource = users;

            if (!dataGridView1.Columns.Contains("btnDelete"))
            {
                DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
                btnDelete.HeaderText = "Thao tác";
                btnDelete.Text = "Xoá";
                btnDelete.Name = "btnDelete";
                btnDelete.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(btnDelete);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["btnDelete"].Index)
            {
                var id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["UserID"].Value);
                var result = MessageBox.Show("Bạn có chắc chắn muốn xoá người dùng này?", "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    var user = dbContext.Users.FirstOrDefault(u => u.UserID == id);
                    if (user != null)
                    {
                        dbContext.Users.DeleteOnSubmit(user);
                        dbContext.SubmitChanges();
                        LoadUserData();
                        MessageBox.Show("Đã xoá người dùng thành công.");
                    }
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            FormMain formMain = new FormMain();
            formMain.Show();
            this.Close();
        }
    }
}
