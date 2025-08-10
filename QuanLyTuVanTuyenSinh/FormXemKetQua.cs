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
                btnThanhToan.Visible = false;
                lbTrangThai.Visible = false;
                return;
            }

            var major = db.Majors.FirstOrDefault(m => m.MajorID == currentRecord.MajorID);

            // Lấy payment MỚI NHẤT của hồ sơ (có thể là 0/1/2)
            var payment = db.Payments
                            .Where(p => p.RecordID == currentRecord.RecordID)
                            .OrderByDescending(p => p.PaymentDate)
                            .FirstOrDefault();

            lbKetQua.Text = currentRecord.ResultStatus == 1 ? "Đậu" :
                            currentRecord.ResultStatus == 2 ? "Rớt" : "Chưa xét";
            int rot = currentRecord.ResultStatus;

            if (rot == 2 || rot == 0)
            {
                // Rớt: ẩn phần thanh toán
                btnThanhToan.Visible = false;
                lbTrangThai.Visible = false;
                groupBox2.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                return;
            }

            // Đang xét / Đậu: hiện học phí
            label8.Visible = true;
            label8.Text = major?.TuitionFee.ToString("N0") + " VNĐ";

            if (payment == null)
            {
                // Chưa có payment
                lbTrangThai.Visible = false;
                btnThanhToan.Visible = true;
                btnThanhToan.Enabled = true;
            }
            else
            {
                // Có payment -> xử lý theo Status
                lbTrangThai.Visible = true;
                btnThanhToan.Visible = false;
                btnThanhToan.Enabled = false;
                groupBox2.Visible = false;
                if (payment.Status == 1) // Completed
                {
                    // CHẠY ĐÚNG BLOCK HOÀN TẤT như yêu cầu
                    lbTrangThai.Text = "Đã thanh toán";
                    lbTrangThai.ForeColor = Color.Green;

                    if (Session.RoleID == 3) // Sinh viên
                    {
                        
                        label7.Visible = true;
                        label6.Location = new Point(37, 119);
                        label7.Location = new Point(37, 194);
                    }
                    else
                    {
                        label7.Visible = true;
                        label6.Location = new Point(400, 125);
                        label7.Location = new Point(400, 182);
                        lbKetQua.Location = new Point(480, 125);
                        label8.Location = new Point(480, 182);
                    }
                }
                else if (payment.Status == 0) // Pending
                {
                    lbTrangThai.Text = "Đợi xác nhận";
                    lbTrangThai.ForeColor = Color.Orange;

                    // Bố cục giữ như nhánh chưa thanh toán
                    if (Session.RoleID == 3)
                    {
                        label6.Location = new Point(37, 119);
                        label7.Location = new Point(37, 194);
                    }
                    else
                    {
                        label6.Location = new Point(400, 125);
                        label7.Location = new Point(400, 182);
                        lbKetQua.Location = new Point(480, 125);
                        label8.Location = new Point(480, 182);
                    }
                }
                else if (payment.Status == 2) // Failed
                {
                    lbTrangThai.Text = "Thanh toán thất bại";
                    lbTrangThai.ForeColor = Color.Red;

                    if (Session.RoleID == 3)
                    {
                        label6.Location = new Point(37, 119);
                        label7.Location = new Point(37, 194);
                    }
                    else
                    {
                        label6.Location = new Point(400, 125);
                        label7.Location = new Point(400, 182);
                        lbKetQua.Location = new Point(480, 125);
                        label8.Location = new Point(480, 182);
                    }
                }
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
                    Image = global::QuanLyTuVanTuyenSinh.Properties.Resources.qrcode_default,
                    Dock = DockStyle.Fill,
                    SizeMode = PictureBoxSizeMode.StretchImage
                });
                qrForm.ShowDialog();

                FormUploadBill formUpload = new FormUploadBill();
                if (formUpload.ShowDialog() != DialogResult.OK) return;

                imagePath = formUpload.SelectedImagePath;
            }

            var major = db.Majors.FirstOrDefault(m => m.MajorID == currentRecord.MajorID);

            // Status theo yêu cầu:
            // 2 (Chuyển khoản)  -> 1 (Completed)
            // 1 (Tiền mặt), 3 (Thẻ) -> 0 (Pending)
            byte status = 0;
            if (method == 2) status = 1; // Completed
            else status = 0;             // Pending

            var newPayment = new Payment
            {
                RecordID = currentRecord.RecordID,
                Amount = major?.TuitionFee ?? 0,
                Method = method,
                PaymentDate = DateTime.Now,
                Status = status,
                BillImagePath = imagePath
            };

            db.Payments.InsertOnSubmit(newPayment);
            db.SubmitChanges();

            // Thông báo tuỳ theo trạng thái
            if (status == 1)
                MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Đã tạo phiếu thanh toán, đợi xác nhận.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Lưu ý: currentStudentInfoID đã set khi load (với SV).
            // Nếu là phụ huynh, bạn có thể set nó theo SelectedValue của combobox.
            if (Session.RoleID == 2 && cbbChonSV.SelectedValue is int infoIdFromParent)
                currentStudentInfoID = infoIdFromParent;

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
