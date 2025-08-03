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
    public partial class FormUploadBill : Form
    {
        public string SelectedImagePath { get; private set; }
        public FormUploadBill()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                SelectedImagePath = ofd.FileName;
                pictureBox1.Image = Image.FromFile(SelectedImagePath);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SelectedImagePath))
            {
                MessageBox.Show("Vui lòng chọn ảnh bill trước khi xác nhận.");
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
