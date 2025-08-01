﻿using System;
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
    public partial class FormQuanLyCoSo : Form
    {
        QL_Tuyen_SinhDataContext db = new QL_Tuyen_SinhDataContext();
        int selectedID = -1;
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        public FormQuanLyCoSo()
        {
            InitializeComponent();
            LoadData();
            dgvCoSo.CellClick += dgvCoSo_CellClick;
        }

        private void LoadData()
        {
            var data = db.Campus.Select(c => new
            {
                c.CampusID,
                c.CampusName,
                c.Address,
                c.Phone,
                c.Email,
                c.Website
            }).ToList();

            dgvCoSo.DataSource = data;

            // Kiểm tra xem cột "Xoá" đã tồn tại chưa
            if (!dgvCoSo.Columns.Contains("Delete"))
            {
                DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
                btnDelete.HeaderText = "Xoá";
                btnDelete.Name = "Delete";
                btnDelete.Text = "Xoá";
                btnDelete.UseColumnTextForButtonValue = true;
                dgvCoSo.Columns.Add(btnDelete);
            }

            dgvCoSo.Columns["CampusID"].Visible = false;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                Campus cs = new Campus
                {
                    CampusName = tbTenCoSo.Text.Trim(),
                    Address = tbDiaChi.Text.Trim(),
                    Phone = tbSDT.Text.Trim(),
                    Email = tbEmail.Text.Trim(),
                    Website = tbWeb.Text.Trim()
                };
                db.Campus.InsertOnSubmit(cs);
                db.SubmitChanges();
                LoadData();
                ClearInput();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedID == -1 || !ValidateInput()) return;

            var cs = db.Campus.FirstOrDefault(x => x.CampusID == selectedID);
            if (cs != null)
            {
                cs.CampusName = tbTenCoSo.Text.Trim();
                cs.Address = tbDiaChi.Text.Trim();
                cs.Phone = tbSDT.Text.Trim();
                cs.Email = tbEmail.Text.Trim();
                cs.Website = tbWeb.Text.Trim();
                db.SubmitChanges();
                LoadData();
                ClearInput();
            }
        }

        private void dgvCoSo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvCoSo.Columns[e.ColumnIndex].Name == "Delete")
            {
                int campusId = Convert.ToInt32(dgvCoSo.Rows[e.RowIndex].Cells["CampusID"].Value);
                var campus = db.Campus.FirstOrDefault(c => c.CampusID == campusId);
                if (campus != null)
                {
                    var result = MessageBox.Show("Bạn có chắc muốn xoá cơ sở này cùng với tất cả ngành, hồ sơ và thanh toán liên quan?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        // Lấy các ngành của cơ sở
                        var majors = db.Majors.Where(m => m.CampusID == campus.CampusID).ToList();

                        foreach (var major in majors)
                        {
                            // Lấy các hồ sơ tuyển sinh của ngành
                            var records = db.AdmissionRecords.Where(r => r.MajorID == major.MajorID).ToList();

                            foreach (var record in records)
                            {
                                // Xoá các thanh toán liên quan đến hồ sơ
                                var payments = db.Payments.Where(p => p.RecordID == record.RecordID).ToList();
                                db.Payments.DeleteAllOnSubmit(payments);

                                // Xoá hồ sơ
                                db.AdmissionRecords.DeleteOnSubmit(record);
                            }

                            // Xoá ngành
                            db.Majors.DeleteOnSubmit(major);
                        }

                        // Xoá cơ sở
                        db.Campus.DeleteOnSubmit(campus);
                        db.SubmitChanges();
                        LoadData();
                    }
                }
            }
            else if (e.RowIndex >= 0) // chọn dòng để sửa
            {
                DataGridViewRow row = dgvCoSo.Rows[e.RowIndex];
                tbTenCoSo.Text = row.Cells["CampusName"].Value.ToString();
                tbDiaChi.Text = row.Cells["Address"].Value.ToString();
                tbSDT.Text = row.Cells["Phone"].Value.ToString();
                tbEmail.Text = row.Cells["Email"].Value.ToString();
                tbWeb.Text = row.Cells["Website"].Value.ToString();
                selectedID = Convert.ToInt32(row.Cells["CampusID"].Value);
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(tbTenCoSo.Text) ||
                string.IsNullOrWhiteSpace(tbDiaChi.Text) ||
                string.IsNullOrWhiteSpace(tbSDT.Text) ||
                string.IsNullOrWhiteSpace(tbEmail.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return false;
            }
            return true;
        }

        private void ClearInput()
        {
            tbTenCoSo.Clear();
            tbDiaChi.Clear();
            tbSDT.Clear();
            tbEmail.Clear();
            tbWeb.Clear();
            selectedID = -1;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            FormMain frmMain = new FormMain();
            frmMain.Show();
            this.Close();
        }

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
        }
    }
}
