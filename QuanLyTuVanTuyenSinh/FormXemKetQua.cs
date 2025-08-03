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
    public partial class FormXemKetQua : Form
    {
        QL_Tuyen_SinhDataContext db = new QL_Tuyen_SinhDataContext();
        int currentStudentInfoID = 0;
        AdmissionRecord currentRecord = null;
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        public FormXemKetQua()
        {
            InitializeComponent();
        }

        private void FormXemKetQua_Load(object sender, EventArgs e)
        {
            if (Session.RoleID == 3) // Sinh viên
            {
                groupBox1.Visible = false;
                label6.Location = new Point(37, 119);
                var student = db.StudentInfos.FirstOrDefault(s => s.StudentUserID == Session.UserID);
                if (student != null)
                {
                    currentStudentInfoID = student.InfoID;
                    LoadRecordAndUI(currentStudentInfoID);
                }
            }
            else if (Session.RoleID == 2) // Phụ huynh
            {
                cbbChonSV.Visible = true;
                label6.Location = new Point(400, 125);
                label7.Location = new Point(400, 182);
                lbKetQua.Location = new Point(480, 125);
                label8.Location = new Point(480, 182);

                var list = db.StudentInfos.Where(x => x.ParentUserID == Session.UserID)
                              .Select(s => new { s.InfoID, s.FullName }).ToList();

                cbbChonSV.DataSource = list;
                cbbChonSV.DisplayMember = "FullName";
                cbbChonSV.ValueMember = "InfoID";

            }

            cbbPhuongThuc.DataSource = new[]
            {
        new { Text = "Tiền mặt", Value = 1 },
        new { Text = "Chuyển khoản", Value = 2 },
        new { Text = "Thẻ", Value = 3 }
    };
            cbbPhuongThuc.DisplayMember = "Text";
            cbbPhuongThuc.ValueMember = "Value";
        }

        public class ComboboxItem
        {
            public int ID { get; set; }
            public string Name { get; set; }
        }
        private void cbbChonSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbChonSV.SelectedValue is int infoID)
            {
                LoadRecordAndUI(infoID);
            }
        }

        private void LoadRecordAndUI(int studentID)
        {
            currentRecord = db.AdmissionRecords.FirstOrDefault(r => r.StudentInfoID == studentID);                 

            if (currentRecord == null)
            {
                lbKetQua.Text = "Chưa đăng ký";
                label8.Text = "-";
                btnThanhToan.Enabled = false;
                return;
            }


            var major = db.Majors.FirstOrDefault(m => m.MajorID == currentRecord.MajorID);
            var payment = db.Payments.FirstOrDefault(p => p.RecordID == currentRecord.RecordID && p.Status == 1);

            lbKetQua.Text = currentRecord.ResultStatus == 1 ? "Đậu" :
                            currentRecord.ResultStatus == 2 ? "Rớt" : "Chưa xét";
            int rot = currentRecord.ResultStatus;

            if (rot == 2)
            {

                btnThanhToan.Visible = false;
                lbTrangThai.Visible = false;
                groupBox2.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
            }
            else
            {
                label8.Visible = true;
                label8.Text = major?.TuitionFee.ToString("N0") + " VNĐ";
                if (payment != null)
                {
                    if (Session.RoleID == 3) // Sinh viên
                    {
                        lbTrangThai.Visible = true;
                        lbTrangThai.Text = "Đã thanh toán";
                        lbTrangThai.ForeColor = Color.Green;
                        btnThanhToan.Visible = false;
                        groupBox2.Visible = false;
                        label7.Visible = true;
                        label6.Location = new Point(37, 119);
                        label7.Location = new Point(37, 194);
                    }
                    else
                    {
                        lbTrangThai.Visible = true;
                        lbTrangThai.Text = "Đã thanh toán";
                        lbTrangThai.ForeColor = Color.Green;
                        btnThanhToan.Visible = false;
                        label7.Visible = true;                       
                        label6.Location = new Point(400, 125);
                        label7.Location = new Point(400, 182);
                        lbKetQua.Location = new Point(480, 125);
                        label8.Location = new Point(480, 182);
                    }

                }
                else
                {
                    lbTrangThai.Visible = false;
                    btnThanhToan.Visible = true;
                }
                btnThanhToan.Enabled = (payment == null);
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (currentRecord == null || cbbPhuongThuc.SelectedValue == null)
            {
                MessageBox.Show("Thông tin không hợp lệ.");
                return;
            }

            var method = (byte)(int)cbbPhuongThuc.SelectedValue;
            string imagePath = null;

            if (method == 2) // Chuyển khoản
            {
                Form qrForm = new Form();
                qrForm.Text = "Quét mã QR";
                qrForm.ClientSize = new Size(300, 300);
                qrForm.Controls.Add(new PictureBox
                {
                    Image = global::QuanLyTuVanTuyenSinh.Properties.Resources.qrcode_default, // thay đường dẫn nếu cần
                    Dock = DockStyle.Fill,
                    SizeMode = PictureBoxSizeMode.StretchImage
                });
                qrForm.ShowDialog();

                FormUploadBill formUpload = new FormUploadBill();
                if (formUpload.ShowDialog() != DialogResult.OK) return;

                imagePath = formUpload.SelectedImagePath;
            }

            var major = db.Majors.FirstOrDefault(m => m.MajorID == currentRecord.MajorID);
            var newPayment = new Payment
            {
                RecordID = currentRecord.RecordID,
                Amount = major?.TuitionFee ?? 0,
                Method = method,
                PaymentDate = DateTime.Now,
                Status = 1,
                BillImagePath = imagePath
            };

            db.Payments.InsertOnSubmit(newPayment);
            db.SubmitChanges();
            MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadRecordAndUI(currentStudentInfoID);
        }

        private void label9_Click(object sender, EventArgs e)
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
