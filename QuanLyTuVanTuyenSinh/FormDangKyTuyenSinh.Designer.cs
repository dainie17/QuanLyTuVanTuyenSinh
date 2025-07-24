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
            panelHeader = new Panel();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            lblTenTruong = new Label();
            lblSdt = new Label();
            label3 = new Label();
            label4 = new Label();
            lblFooter = new Label();
            label5 = new Label();
            cbbChonSV = new ComboBox();
            cbbChonNganh = new ComboBox();
            btnDangKyTs = new Button();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.OrangeRed;
            panelHeader.Controls.Add(label1);
            panelHeader.Controls.Add(label2);
            panelHeader.Controls.Add(pictureBox1);
            panelHeader.Controls.Add(lblTenTruong);
            panelHeader.Controls.Add(lblSdt);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1000, 80);
            panelHeader.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(90, 4);
            label1.Name = "label1";
            label1.Size = new Size(112, 28);
            label1.TabIndex = 4;
            label1.Text = "Tên trường";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.OrangeRed;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(802, 26);
            label2.Name = "label2";
            label2.Size = new Size(169, 28);
            label2.TabIndex = 3;
            label2.Text = "SDT: 0886386654";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Padding = new Padding(10);
            pictureBox1.Size = new Size(84, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblTenTruong
            // 
            lblTenTruong.AutoSize = true;
            lblTenTruong.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTenTruong.ForeColor = Color.White;
            lblTenTruong.Location = new Point(90, 40);
            lblTenTruong.Name = "lblTenTruong";
            lblTenTruong.Size = new Size(303, 28);
            lblTenTruong.TabIndex = 1;
            lblTenTruong.Text = "CỔNG THÔNG TIN TUYỂN SINH";
            // 
            // lblSdt
            // 
            lblSdt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSdt.AutoSize = true;
            lblSdt.Font = new Font("Segoe UI", 10F);
            lblSdt.ForeColor = Color.White;
            lblSdt.Location = new Point(4050, 30);
            lblSdt.Name = "lblSdt";
            lblSdt.Size = new Size(138, 23);
            lblSdt.TabIndex = 2;
            lblSdt.Text = "SDT: 0886386654";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.OrangeRed;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(591, 421);
            label3.Name = "label3";
            label3.Size = new Size(397, 20);
            label3.TabIndex = 12;
            label3.Text = "Tổng đài hỗ trợ - Email: tuyensinh-daucap@hanoiedu.vn";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.OrangeRed;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(685, 380);
            label4.Name = "label4";
            label4.Size = new Size(303, 28);
            label4.TabIndex = 11;
            label4.Text = "CỔNG THÔNG TIN TUYỂN SINH";
            // 
            // lblFooter
            // 
            lblFooter.BackColor = Color.OrangeRed;
            lblFooter.Dock = DockStyle.Bottom;
            lblFooter.Font = new Font("Segoe UI", 9F);
            lblFooter.ForeColor = Color.White;
            lblFooter.Location = new Point(0, 370);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new Size(1000, 80);
            lblFooter.TabIndex = 10;
            lblFooter.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(358, 96);
            label5.Name = "label5";
            label5.Size = new Size(271, 38);
            label5.TabIndex = 13;
            label5.Text = "Đăng ký tuyển sinh";
            // 
            // cbbChonSV
            // 
            cbbChonSV.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbbChonSV.FormattingEnabled = true;
            cbbChonSV.Location = new Point(90, 156);
            cbbChonSV.Name = "cbbChonSV";
            cbbChonSV.Size = new Size(808, 36);
            cbbChonSV.TabIndex = 14;
            // 
            // cbbChonNganh
            // 
            cbbChonNganh.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbbChonNganh.FormattingEnabled = true;
            cbbChonNganh.Location = new Point(93, 223);
            cbbChonNganh.Name = "cbbChonNganh";
            cbbChonNganh.Size = new Size(805, 36);
            cbbChonNganh.TabIndex = 15;
            // 
            // btnDangKyTs
            // 
            btnDangKyTs.BackColor = Color.OrangeRed;
            btnDangKyTs.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDangKyTs.ForeColor = Color.White;
            btnDangKyTs.Location = new Point(93, 287);
            btnDangKyTs.Name = "btnDangKyTs";
            btnDangKyTs.Size = new Size(805, 41);
            btnDangKyTs.TabIndex = 16;
            btnDangKyTs.Text = "Đăng ký ngay";
            btnDangKyTs.UseVisualStyleBackColor = false;
            // 
            // FormDangKyTuyenSinh
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 450);
            Controls.Add(btnDangKyTs);
            Controls.Add(cbbChonNganh);
            Controls.Add(cbbChonSV);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(lblFooter);
            Controls.Add(panelHeader);
            Name = "FormDangKyTuyenSinh";
            Text = "Đăng ký tuyển sinh";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private ComboBox cbbChonSV;
        private ComboBox cbbChonNganh;
        private Button btnDangKyTs;
    }
}