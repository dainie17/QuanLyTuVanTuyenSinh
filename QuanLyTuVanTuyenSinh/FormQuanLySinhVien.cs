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
