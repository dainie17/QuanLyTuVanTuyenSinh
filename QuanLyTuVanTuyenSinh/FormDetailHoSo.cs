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
                var payment = db.Payments
                                .Where(p => p.RecordID == recordId)
                                .OrderByDescending(p => p.PaymentDate)
                                .FirstOrDefault(); // Lấy lần thanh toán mới nhất

                lbThanhToan.Text = payment != null && payment.Status == 1 ? "Đã thanh toán" : "Chưa";
                lbNgayThanhToan.Text = payment?.PaymentDate.ToString("dd/MM/yyyy") ?? "-";
                lbPhuongThuc.Text = payment != null ? GetPaymentMethodName(payment.Method) : "-";
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
