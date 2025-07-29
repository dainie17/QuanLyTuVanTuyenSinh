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
    public partial class FormFormQuanLyHoSo : Form
    {
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        public FormFormQuanLyHoSo()
        {
            InitializeComponent();
        }

        private void FormFormQuanLyHoSo_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            var db = new QL_Tuyen_SinhDataContext();

            var data = from ar in db.AdmissionRecords
                       join si in db.StudentInfos on ar.StudentInfoID equals si.InfoID
                       join m in db.Majors on ar.MajorID equals m.MajorID
                       join c in db.Campus on m.CampusID equals c.CampusID
                       select new
                       {
                           ar.RecordID,
                           HoTen = si.FullName,
                           NgaySinh = si.BirthDate,
                           GioiTinh = si.Gender == true ? "Nam" : "Nữ",
                           NgayDangKy = ar.RegistrationDate,
                           DiemThi = ar.ExamScore,
                           Nganh = m.MajorName,
                           CoSo = c.CampusName,
                           TrangThai = ar.ResultStatus == 0 ? "Chờ duyệt" :
                                       ar.ResultStatus == 1 ? "Đậu" : "Rớt"
                       };

            dgvHoSo.DataSource = data.ToList();

            if (!dgvHoSo.Columns.Contains("btnXoa"))
            {
                DataGridViewButtonColumn btnXoa = new DataGridViewButtonColumn();
                btnXoa.Name = "btnXoa";
                btnXoa.HeaderText = "Xoá";
                btnXoa.Text = "Xoá";
                btnXoa.UseColumnTextForButtonValue = true;
                dgvHoSo.Columns.Add(btnXoa);
            }
        }

        private void dgvHoSo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var recordID = (int)dgvHoSo.Rows[e.RowIndex].Cells["RecordID"].Value;

                if (dgvHoSo.Columns[e.ColumnIndex].Name == "btnXoa")
                {
                    var confirm = MessageBox.Show("Bạn có chắc chắn muốn xoá?", "Xác nhận", MessageBoxButtons.YesNo);
                    if (confirm == DialogResult.Yes)
                    {
                        var db = new QL_Tuyen_SinhDataContext();
                        var record = db.AdmissionRecords.FirstOrDefault(x => x.RecordID == recordID);
                        if (record != null)
                        {
                            // Xoá các bản ghi payment liên quan
                            var payments = db.Payments.Where(p => p.RecordID == record.RecordID).ToList();
                            db.Payments.DeleteAllOnSubmit(payments);

                            // Xoá hồ sơ
                            db.AdmissionRecords.DeleteOnSubmit(record);
                            db.SubmitChanges();

                            LoadData();
                        }
                    }
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            FormMain frm = new FormMain();
            frm.Show();
            this.Close();
        }

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
        }

        private void dgvHoSo_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var recordID = (int)dgvHoSo.Rows[e.RowIndex].Cells["RecordID"].Value;
                // Mở form chi tiết
                var db = new QL_Tuyen_SinhDataContext();
                var record = (from ar in db.AdmissionRecords
                              where ar.RecordID == recordID
                              select ar).FirstOrDefault();

                if (record != null)
                {
                    FormDetailHoSo frm = new FormDetailHoSo(record);
                    frm.ShowDialog();
                    LoadData();
                }
            }
        }
    }
}
