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
    public partial class FormXemNganhHoc : Form
    {
        public FormXemNganhHoc()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.FormXemNganhHoc_Load);
        }

        private void FormXemNganhHoc_Load(object sender, EventArgs e)
        {
            using (var db = new QL_Tuyen_SinhDataContext())
            {
                var majors = db.Majors.ToList();
                int y = 140;
                foreach (var major in majors)
                {
                    Button btn = new Button();
                    btn.Text = major.MajorName;
                    btn.Tag = major.Description;
                    btn.Width = 200;
                    btn.Height = 40;
                    btn.Left = 40;
                    btn.Top = y;
                    btn.BackColor = Color.OrangeRed;
                    btn.ForeColor = Color.White;
                    btn.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                    btn.Click += (s, ev) =>
                    {
                        lbMoTa.Text = btn.Tag?.ToString();
                    };

                    this.Controls.Add(btn);
                    y += 50;
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
