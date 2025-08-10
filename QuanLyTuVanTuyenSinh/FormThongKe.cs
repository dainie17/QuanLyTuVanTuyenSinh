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
    public partial class FormThongKe : Form
    {
        public FormThongKe()
        {
            InitializeComponent();
            LoadFilters();
        }

        private void LoadFilters()
        {
            using (var db = new QL_Tuyen_SinhDataContext())
            {
                var campuses = db.Campus
                    .Select(c => new { c.CampusID, c.CampusName })
                    .ToList();
                campuses.Insert(0, new { CampusID = 0, CampusName = "Tất cả cơ sở" });

                cboCampus.DisplayMember = "CampusName";
                cboCampus.ValueMember = "CampusID";
                cboCampus.DataSource = campuses;
            }
        }

        private void cboCampus_SelectedIndexChanged(object sender, EventArgs e)
        {
            int campusId = (int)cboCampus.SelectedValue;
            using (var db = new QL_Tuyen_SinhDataContext())
            {
                var majors = db.Majors
                    .Where(m => campusId == 0 || m.CampusID == campusId)
                    .Select(m => new { m.MajorID, m.MajorName })
                    .ToList();
                majors.Insert(0, new { MajorID = 0, MajorName = "Tất cả ngành" });

                cboMajor.DisplayMember = "MajorName";
                cboMajor.ValueMember = "MajorID";
                cboMajor.DataSource = majors;
            }
        }

        private class StatSummary
        {
            public int Total { get; set; }
            public int Pass { get; set; }
            public int Fail { get; set; }
            public int Pending { get; set; }
            public int Paid { get; set; }
            public int PayPending { get; set; }
            public int PayFailed { get; set; }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            int campusId = (int)cboCampus.SelectedValue;
            int majorId = (int)cboMajor.SelectedValue;
            DateTime? from = dtFrom.Checked ? dtFrom.Value.Date : (DateTime?)null;
            DateTime? to = dtTo.Checked ? dtTo.Value.Date.AddDays(1).AddTicks(-1) : (DateTime?)null;

            using (var db = new QL_Tuyen_SinhDataContext())
            {
                var q = db.AdmissionRecords.AsQueryable();

                if (majorId != 0) q = q.Where(r => r.MajorID == majorId);
                if (campusId != 0) q = q.Where(r => r.Major.CampusID == campusId);
                if (from.HasValue) q = q.Where(r => r.RegistrationDate >= from.Value);
                if (to.HasValue) q = q.Where(r => r.RegistrationDate <= to.Value);

                // Danh sách chi tiết
                var detail = q.Select(r => new
                {
                    r.RecordID,
                    Student = r.StudentInfo.FullName,
                    Campus = r.Major.Campus.CampusName,
                    Major = r.Major.MajorName,
                    r.RegistrationDate,
                    Result = r.ResultStatus, // 0/1/2
                    ExamScore = r.ExamScore,
                    // Payment mới nhất
                    Payment = db.Payments.Where(p => p.RecordID == r.RecordID)
                                          .OrderByDescending(p => p.PaymentDate)
                                          .FirstOrDefault()
                })
                .AsEnumerable()
                .Select(x => new
                {
                    x.RecordID,
                    x.Student,
                    x.Campus,
                    x.Major,
                    x.RegistrationDate,
                    ResultText = x.Result == 1 ? "Đậu" : x.Result == 2 ? "Rớt" : "Chưa xét",
                    x.ExamScore,
                    PaymentStatus = x.Payment == null ? "Chưa thanh toán"
                                    : x.Payment.Status == 1 ? "Đã thanh toán"
                                    : x.Payment.Status == 0 ? "Đợi xác nhận"
                                    : "Thất bại"
                })
                .ToList();

                //dgvDetail.DataSource = detail;

                // Tổng quan
                var summary = new StatSummary
                {
                    Total = detail.Count,
                    Pass = detail.Count(d => d.ResultText == "Đậu"),
                    Fail = detail.Count(d => d.ResultText == "Rớt"),
                    Pending = detail.Count(d => d.ResultText == "Chưa xét"),
                    Paid = detail.Count(d => d.PaymentStatus == "Đã thanh toán"),
                    PayPending = detail.Count(d => d.PaymentStatus == "Đợi xác nhận"),
                    PayFailed = detail.Count(d => d.PaymentStatus == "Thất bại"),
                };
                UpdateSummaryCards(summary);

                // Dữ liệu cho chart theo ngành
                var byMajor = detail.GroupBy(d => d.Major)
                                    .Select(g => new { Major = g.Key, Count = g.Count() })
                                    .OrderByDescending(x => x.Count)
                                    .ToList();
                BindChart(chartByMajor, "Ngành", byMajor);

                // Dữ liệu cho chart theo cơ sở
                var byCampus = detail.GroupBy(d => d.Campus)
                                     .Select(g => new { Campus = g.Key, Count = g.Count() })
                                     .OrderByDescending(x => x.Count)
                                     .ToList();
                BindChart(chartByCampus, "Cơ sở", byCampus);
            }
        }

        private void UpdateSummaryCards(StatSummary s)
        {
            lblTotal.Text = s.Total.ToString();
            lblPass.Text = s.Pass.ToString();
            lblFail.Text = s.Fail.ToString();
            lblPending.Text = s.Pending.ToString();
            lblPaid.Text = s.Paid.ToString();
            lblPayPending.Text = s.PayPending.ToString();
            lblPayFailed.Text = s.PayFailed.ToString();
        }

        private void BindChart(System.Windows.Forms.DataVisualization.Charting.Chart chart, string seriesName, IEnumerable<dynamic> data)
        {
            chart.Series.Clear();
            chart.ChartAreas.Clear();
            chart.ChartAreas.Add("ca");
            var series = chart.Series.Add(seriesName);
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column; // hoặc Doughnut
            series.XValueMember = "Key";
            series.YValueMembers = "Value";

            // bind
            series.Points.Clear();
            foreach (var item in data)
            {
                // item: { Major/Campus, Count }
                var label = item.GetType().GetProperty("Major") != null ? item.Major : item.Campus;
                series.Points.AddXY(label, item.Count);
            }
            chart.Legends.Clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormMain form = new FormMain();
            form.Show();
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            FormMain form = new FormMain();
            form.Show();
            this.Close();
        }
    }
}
