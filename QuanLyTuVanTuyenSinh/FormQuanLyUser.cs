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
    public partial class FormQuanLyUser : Form
    {
        private QL_Tuyen_SinhDataContext dbContext;
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

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
                        // Xoá nếu là sinh viên
                        var studentInfo = dbContext.StudentInfos.FirstOrDefault(s => s.StudentUserID == user.UserID);
                        if (studentInfo != null)
                        {
                            var records = dbContext.AdmissionRecords.Where(r => r.StudentInfoID == studentInfo.InfoID).ToList();
                            foreach (var record in records)
                            {
                                var payments = dbContext.Payments.Where(p => p.RecordID == record.RecordID).ToList();
                                dbContext.Payments.DeleteAllOnSubmit(payments);
                                dbContext.AdmissionRecords.DeleteOnSubmit(record);
                            }
                            dbContext.StudentInfos.DeleteOnSubmit(studentInfo);
                        }

                        // Nếu là phụ huynh - cần cập nhật hoặc xoá các studentInfo liên quan
                        var parentLinkedStudents = dbContext.StudentInfos.Where(s => s.ParentUserID == user.UserID).ToList();
                        foreach (var s in parentLinkedStudents)
                            s.ParentUserID = null; // hoặc có thể xoá luôn nếu cần

                        // Nếu là admin đã duyệt hồ sơ
                        var approvedRecords = dbContext.AdmissionRecords.Where(r => r.ApprovedByAdminID == user.UserID).ToList();
                        foreach (var r in approvedRecords)
                            r.ApprovedByAdminID = null;

                        // Xoá cuối cùng
                        dbContext.Users.DeleteOnSubmit(user);
                        dbContext.SubmitChanges();
                        LoadUserData();
                        MessageBox.Show("Đã xoá người dùng và dữ liệu liên quan thành công.");
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

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
        }
    }
}
