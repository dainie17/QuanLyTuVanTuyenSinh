using System.Drawing;
using System.Windows.Forms;

namespace QuanLyTuVanTuyenSinh
{
    partial class FormDangKyTuyenSinh
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTenTruong = new System.Windows.Forms.Label();
            this.lblSdt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFooter = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbChonCoSo = new System.Windows.Forms.ComboBox();
            this.cbbChonNganh = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbDiemThi = new System.Windows.Forms.TextBox();
            this.cbbChonSinhVien = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pbAnhNganh = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbMoTa = new System.Windows.Forms.Label();
            this.btnDangKyTs = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnhNganh)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.OrangeRed;
            this.panelHeader.Controls.Add(this.label6);
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Controls.Add(this.label2);
            this.panelHeader.Controls.Add(this.pictureBox1);
            this.panelHeader.Controls.Add(this.lblTenTruong);
            this.panelHeader.Controls.Add(this.lblSdt);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1000, 64);
            this.panelHeader.TabIndex = 6;
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(952, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 34);
            this.label6.TabIndex = 7;
            this.label6.Text = "X";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(90, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên trường";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.OrangeRed;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(769, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "SDT: 0886386654";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.pictureBox1.Size = new System.Drawing.Size(84, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblTenTruong
            // 
            this.lblTenTruong.AutoSize = true;
            this.lblTenTruong.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenTruong.ForeColor = System.Drawing.Color.White;
            this.lblTenTruong.Location = new System.Drawing.Point(90, 32);
            this.lblTenTruong.Name = "lblTenTruong";
            this.lblTenTruong.Size = new System.Drawing.Size(303, 28);
            this.lblTenTruong.TabIndex = 1;
            this.lblTenTruong.Text = "CỔNG THÔNG TIN TUYỂN SINH";
            // 
            // lblSdt
            // 
            this.lblSdt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSdt.AutoSize = true;
            this.lblSdt.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSdt.ForeColor = System.Drawing.Color.White;
            this.lblSdt.Location = new System.Drawing.Point(4050, 24);
            this.lblSdt.Name = "lblSdt";
            this.lblSdt.Size = new System.Drawing.Size(138, 23);
            this.lblSdt.TabIndex = 2;
            this.lblSdt.Text = "SDT: 0886386654";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.OrangeRed;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(563, 512);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(397, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tổng đài hỗ trợ - Email: tuyensinh-daucap@hanoiedu.vn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.OrangeRed;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(657, 479);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(303, 28);
            this.label4.TabIndex = 11;
            this.label4.Text = "CỔNG THÔNG TIN TUYỂN SINH";
            // 
            // lblFooter
            // 
            this.lblFooter.BackColor = System.Drawing.Color.OrangeRed;
            this.lblFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblFooter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFooter.ForeColor = System.Drawing.Color.White;
            this.lblFooter.Location = new System.Drawing.Point(0, 473);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(1000, 64);
            this.lblFooter.TabIndex = 10;
            this.lblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(358, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(271, 38);
            this.label5.TabIndex = 13;
            this.label5.Text = "Đăng ký tuyển sinh";
            // 
            // cbbChonCoSo
            // 
            this.cbbChonCoSo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbChonCoSo.FormattingEnabled = true;
            this.cbbChonCoSo.Location = new System.Drawing.Point(6, 20);
            this.cbbChonCoSo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbChonCoSo.Name = "cbbChonCoSo";
            this.cbbChonCoSo.Size = new System.Drawing.Size(395, 36);
            this.cbbChonCoSo.TabIndex = 14;
            this.cbbChonCoSo.SelectedIndexChanged += new System.EventHandler(this.cbbChonCoSo_SelectedIndexChanged);
            // 
            // cbbChonNganh
            // 
            this.cbbChonNganh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbChonNganh.FormattingEnabled = true;
            this.cbbChonNganh.Location = new System.Drawing.Point(6, 20);
            this.cbbChonNganh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbChonNganh.Name = "cbbChonNganh";
            this.cbbChonNganh.Size = new System.Drawing.Size(395, 36);
            this.cbbChonNganh.TabIndex = 15;
            this.cbbChonNganh.SelectedIndexChanged += new System.EventHandler(this.cbbChonNganh_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbDiemThi);
            this.groupBox2.Location = new System.Drawing.Point(90, 326);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(401, 58);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Điểm thi tốt nghiệp";
            // 
            // tbDiemThi
            // 
            this.tbDiemThi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDiemThi.Location = new System.Drawing.Point(6, 15);
            this.tbDiemThi.Name = "tbDiemThi";
            this.tbDiemThi.Size = new System.Drawing.Size(395, 34);
            this.tbDiemThi.TabIndex = 10;
            this.tbDiemThi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbbChonSinhVien
            // 
            this.cbbChonSinhVien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbChonSinhVien.FormattingEnabled = true;
            this.cbbChonSinhVien.Location = new System.Drawing.Point(6, 20);
            this.cbbChonSinhVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbChonSinhVien.Name = "cbbChonSinhVien";
            this.cbbChonSinhVien.Size = new System.Drawing.Size(395, 36);
            this.cbbChonSinhVien.TabIndex = 14;
            this.cbbChonSinhVien.SelectedIndexChanged += new System.EventHandler(this.cbbChonCoSo_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbChonSinhVien);
            this.groupBox1.Location = new System.Drawing.Point(90, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 64);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn sinh viên";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbbChonCoSo);
            this.groupBox3.Location = new System.Drawing.Point(90, 188);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(401, 62);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chọn cơ sở";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbbChonNganh);
            this.groupBox4.Location = new System.Drawing.Point(90, 256);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(401, 64);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chọn ngành";
            // 
            // pbAnhNganh
            // 
            this.pbAnhNganh.Location = new System.Drawing.Point(497, 124);
            this.pbAnhNganh.Name = "pbAnhNganh";
            this.pbAnhNganh.Size = new System.Drawing.Size(401, 188);
            this.pbAnhNganh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAnhNganh.TabIndex = 25;
            this.pbAnhNganh.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(497, 347);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 25);
            this.label7.TabIndex = 26;
            this.label7.Text = "Mô tả:";
            // 
            // tbMoTa
            // 
            this.tbMoTa.AutoSize = true;
            this.tbMoTa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMoTa.Location = new System.Drawing.Point(570, 349);
            this.tbMoTa.Name = "tbMoTa";
            this.tbMoTa.Size = new System.Drawing.Size(54, 22);
            this.tbMoTa.TabIndex = 27;
            this.tbMoTa.Text = "mô tả";
            // 
            // btnDangKyTs
            // 
            this.btnDangKyTs.BackColor = System.Drawing.Color.OrangeRed;
            this.btnDangKyTs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangKyTs.ForeColor = System.Drawing.Color.White;
            this.btnDangKyTs.Location = new System.Drawing.Point(96, 400);
            this.btnDangKyTs.Name = "btnDangKyTs";
            this.btnDangKyTs.Size = new System.Drawing.Size(802, 55);
            this.btnDangKyTs.TabIndex = 28;
            this.btnDangKyTs.Text = "Đăng ký";
            this.btnDangKyTs.UseVisualStyleBackColor = false;
            this.btnDangKyTs.Click += new System.EventHandler(this.btnDangKyTs_Click);
            // 
            // FormDangKyTuyenSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 537);
            this.Controls.Add(this.btnDangKyTs);
            this.Controls.Add(this.tbMoTa);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pbAnhNganh);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblFooter);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormDangKyTuyenSinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký tuyển sinh";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAnhNganh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelHeader;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label lblTenTruong;
        private Label lblSdt;
        private Label label3;
        private Label label4;
        private Label lblFooter;
        private Label label5;
        private ComboBox cbbChonCoSo;
        private ComboBox cbbChonNganh;
        private GroupBox groupBox2;
        private TextBox tbDiemThi;
        private ComboBox cbbChonSinhVien;
        private Label label6;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private PictureBox pbAnhNganh;
        private Label label7;
        private Label tbMoTa;
        private Button btnDangKyTs;
    }
}