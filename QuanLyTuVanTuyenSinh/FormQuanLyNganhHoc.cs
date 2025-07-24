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
    public partial class FormQuanLyNganhHoc : Form
    {
        QL_Tuyen_SinhDataContext db = new QL_Tuyen_SinhDataContext();
        int selectedMajorId = -1;
        public FormQuanLyNganhHoc()
        {
            InitializeComponent();
            LoadCosoCombobox();
            LoadData();
            dgvNganhHoc.CellClick += dgvNganhHoc_CellClick;
        }

        private void LoadCosoCombobox()
        {
            comboBox1.DataSource = db.Campus.ToList();
            comboBox1.DisplayMember = "CampusName";
            comboBox1.ValueMember = "CampusID";
        }

        private void LoadData()
        {
            var data = from m in db.Majors
                       join c in db.Campus on m.CampusID equals c.CampusID
                       select new
                       {
                           m.MajorID,
                           m.MajorName,
                           m.TuitionFee,
                           m.Description,
                           CampusName = c.CampusName
                       };
            dgvNganhHoc.DataSource = data.ToList();

            if (!dgvNganhHoc.Columns.Contains("Delete"))
            {
                DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
                btnDelete.HeaderText = "Xoá";
                btnDelete.Name = "Delete";
                btnDelete.Text = "Xoá";
                btnDelete.UseColumnTextForButtonValue = true;
                dgvNganhHoc.Columns.Add(btnDelete);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbTenNganh.Text) || string.IsNullOrWhiteSpace(tbHocPhi.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            Major m = new Major
            {
                MajorName = tbTenNganh.Text,
                TuitionFee = decimal.Parse(tbHocPhi.Text),
                Description = textBox1.Text,
                CampusID = (int)comboBox1.SelectedValue
            };
            db.Majors.InsertOnSubmit(m);
            db.SubmitChanges();
            LoadData();
            ClearForm();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (selectedMajorId == -1)
            {
                MessageBox.Show("Vui lòng chọn ngành để sửa.");
                return;
            }

            var m = db.Majors.FirstOrDefault(x => x.MajorID == selectedMajorId);
            if (m != null)
            {
                m.MajorName = tbTenNganh.Text;
                m.TuitionFee = decimal.Parse(tbHocPhi.Text);
                m.Description = textBox1.Text;
                m.CampusID = (int)comboBox1.SelectedValue;
                db.SubmitChanges();
                LoadData();
                ClearForm();
            }
        }

        private void dgvNganhHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dgvNganhHoc.Columns[e.ColumnIndex].Name == "Delete")
                {
                    int majorId = Convert.ToInt32(dgvNganhHoc.Rows[e.RowIndex].Cells["MajorID"].Value);
                    var m = db.Majors.FirstOrDefault(x => x.MajorID == majorId);
                    if (m != null && MessageBox.Show("Xác nhận xoá?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        db.Majors.DeleteOnSubmit(m);
                        db.SubmitChanges();
                        LoadData();
                    }
                }
                else
                {
                    selectedMajorId = Convert.ToInt32(dgvNganhHoc.Rows[e.RowIndex].Cells["MajorID"].Value);
                    tbTenNganh.Text = dgvNganhHoc.Rows[e.RowIndex].Cells["MajorName"].Value.ToString();
                    tbHocPhi.Text = Convert.ToDecimal(dgvNganhHoc.Rows[e.RowIndex].Cells["TuitionFee"].Value).ToString("N0"); // Hiển thị dạng 14,000,000
                    textBox1.Text = dgvNganhHoc.Rows[e.RowIndex].Cells["Description"].Value.ToString();
                    comboBox1.Text = dgvNganhHoc.Rows[e.RowIndex].Cells["CampusName"].Value.ToString();
                }
            }
        }

        private void ClearForm()
        {
            tbTenNganh.Clear();
            tbHocPhi.Clear();
            textBox1.Clear();
            comboBox1.SelectedIndex = 0;
            selectedMajorId = -1;
        }
    }
}
