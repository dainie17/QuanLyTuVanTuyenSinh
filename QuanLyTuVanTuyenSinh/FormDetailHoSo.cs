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
    public partial class FormDetailHoSo : Form
    {

        private int _recordId;
        private AdmissionRecord _record;
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        public FormDetailHoSo(AdmissionRecord record)
        {
            InitializeComponent();
            _record = record;
            _recordId = _record.RecordID;

            // Sửa event: tránh dùng handler "btnRot_Click" (dùng cho Hồ sơ rớt)
            btnHuyThanhToan.Click -= btnRot_Click;
            btnHuyThanhToan.Click += btnHuyThanhToan_Click;

            LoadDetail();
            LoadPaymentInfo(_record.RecordID);
        }



        private void LoadDetail()
        {
            lbName.Text = _record.StudentInfo.FullName;
            lbNgaySinh.Text = _record.StudentInfo.BirthDate?.ToString("dd/MM/yyyy");
            lbDiaChi.Text = _record.StudentInfo.Address;
            lbGioiTinh.Text = _record.StudentInfo.Gender == true ? "Nam" : "Nữ";
            lbCanCuoc.Text = _record.StudentInfo.NationalID;
            lbNganhHoc.Text = _record.Major.MajorName;
            lbNgayDangKy.Text = _record.RegistrationDate.ToString("dd/MM/yyyy");
            lbDiemThi.Text = _record.ExamScore?.ToString();
        }

        private void LoadPaymentInfo(int recordId)
        {
            using (var db = new QL_Tuyen_SinhDataContext())
            {
                // Lấy payment MỚI NHẤT bất kể status
                var payment = db.Payments
                                .Where(p => p.RecordID == recordId)
                                .OrderByDescending(p => p.PaymentDate)
                                .FirstOrDefault();

                // Mặc định
                lbThanhToan.Text = "Chưa";
                lbThanhToan.ForeColor = Color.Black;
                lbNgayThanhToan.Text = "-";
                lbPhuongThuc.Text = "-";
                pbBill.Image = null;

                btnXacNhanThanhToan.Visible = false;
                btnHuyThanhToan.Visible = false;

                if (payment != null)
                {
                    // Hiển thị info chung
                    lbNgayThanhToan.Text = payment.PaymentDate.ToString("dd/MM/yyyy");
                    lbPhuongThuc.Text = GetPaymentMethodName(payment.Method);

                    if (!string.IsNullOrEmpty(payment.BillImagePath) && System.IO.File.Exists(payment.BillImagePath))
                        pbBill.Image = Image.FromFile(payment.BillImagePath);

                    // Hiển thị theo Status
                    if (payment.Status == 1) // Completed
                    {
                        lbThanhToan.Text = "Đã thanh toán";
                        lbThanhToan.ForeColor = Color.Green;

                        // ẨN 2 nút theo yêu cầu
                        btnXacNhanThanhToan.Visible = false;
                        btnHuyThanhToan.Visible = false;
                    }
                    else if (payment.Status == 0) // Pending
                    {
                        lbThanhToan.Text = "Đợi xác nhận";
                        lbThanhToan.ForeColor = Color.Orange;

                        // Cho phép xác nhận / huỷ
                        btnXacNhanThanhToan.Visible = true;
                        btnHuyThanhToan.Visible = true;

                        // Lưu id payment vào Tag để thao tác
                        btnXacNhanThanhToan.Tag = payment.PaymentID;
                        btnHuyThanhToan.Tag = payment.PaymentID;
                    }
                    else if (payment.Status == 2) // Failed
                    {
                        lbThanhToan.Text = "Thanh toán thất bại";
                        lbThanhToan.ForeColor = Color.Red;

                        // Cho phép xác nhận lại hoặc tiếp tục huỷ
                        btnXacNhanThanhToan.Visible = true;
                        btnHuyThanhToan.Visible = true;

                        btnXacNhanThanhToan.Tag = payment.PaymentID;
                        btnHuyThanhToan.Tag = payment.PaymentID;
                    }
                }

                // Nếu hồ sơ đã thanh toán xong → ẩn cụm đánh giá (giống logic cũ của bạn)
                // (Giữ nguyên nếu bạn muốn tiếp tục cho đánh giá riêng)
                // if (payment?.Status == 1) { btnDau.Visible = false; btnRot.Visible = false; label13.Visible = false; }
            }
        }


        private string GetPaymentMethodName(int method)
        {
            switch (method)
            {
                case 1: return "Tiền mặt";
                case 2: return "Chuyển khoản";
                case 3: return "Thẻ";
                default: return "Không xác định";
            }
        }

        private void btnLuuThanhToan_Click(object sender, EventArgs e)
        {
            // Xác nhận thanh toán -> Completed
            int paymentId = 0;
            if (btnXacNhanThanhToan.Tag is int tagId) paymentId = tagId;

            using (var db = new QL_Tuyen_SinhDataContext())
            {
                Payment payment = null;

                if (paymentId > 0)
                {
                    payment = db.Payments.FirstOrDefault(p => p.PaymentID == paymentId);
                }
                else
                {
                    // fallback: lấy payment mới nhất
                    payment = db.Payments.Where(p => p.RecordID == _recordId)
                                         .OrderByDescending(p => p.PaymentDate)
                                         .FirstOrDefault();
                }

                if (payment == null)
                {
                    MessageBox.Show("Chưa có giao dịch để xác nhận.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                payment.Status = 1; // Completed
                db.SubmitChanges();

                MessageBox.Show("Đã xác nhận thanh toán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            LoadPaymentInfo(_recordId);
        }

        private void btnHuyThanhToan_Click(object sender, EventArgs e)
        {
            int paymentId = 0;
            if (btnHuyThanhToan.Tag is int tagId) paymentId = tagId;

            using (var db = new QL_Tuyen_SinhDataContext())
            {
                Payment payment = null;

                if (paymentId > 0)
                {
                    payment = db.Payments.FirstOrDefault(p => p.PaymentID == paymentId);
                }
                else
                {
                    payment = db.Payments.Where(p => p.RecordID == _recordId)
                                         .OrderByDescending(p => p.PaymentDate)
                                         .FirstOrDefault();
                }

                if (payment == null)
                {
                    MessageBox.Show("Chưa có giao dịch để huỷ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                payment.Status = 2; // Failed
                db.SubmitChanges();

                MessageBox.Show("Đã đánh dấu giao dịch: Thanh toán thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            LoadPaymentInfo(_recordId);
        }

        private void btnDau_Click(object sender, EventArgs e)
        {
            using (var db = new QL_Tuyen_SinhDataContext())
            {
                var record = db.AdmissionRecords.FirstOrDefault(r => r.RecordID == _recordId);
                if (record != null)
                {
                    record.ResultStatus = 1; // ĐẬU
                    record.ResultUpdateDate = DateTime.Now;
                    record.ApprovedByAdminID = Session.UserID;
                    db.SubmitChanges();
                    MessageBox.Show("Đã đánh giá ĐẬU cho hồ sơ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy hồ sơ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRot_Click(object sender, EventArgs e)
        {
            using (var db = new QL_Tuyen_SinhDataContext())
            {
                var record = db.AdmissionRecords.FirstOrDefault(r => r.RecordID == _recordId);
                if (record != null)
                {
                    record.ResultStatus = 2; // RỚT
                    record.ResultUpdateDate = DateTime.Now;
                    record.ApprovedByAdminID = Session.UserID;
                    db.SubmitChanges();
                    MessageBox.Show("Đã đánh giá RỚT cho hồ sơ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy hồ sơ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void FormDetailHoSo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
        }
    }
}
