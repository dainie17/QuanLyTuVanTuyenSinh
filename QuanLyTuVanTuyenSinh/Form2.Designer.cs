using System.Drawing;
using System.Windows.Forms;

namespace QuanLyTuVanTuyenSinh
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTenTruong = new System.Windows.Forms.Label();
            this.lblSdt = new System.Windows.Forms.Label();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.lbDangky = new System.Windows.Forms.Label();
            this.lblFooter = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbSinhVien = new System.Windows.Forms.CheckBox();
            this.cbPhuHuynh = new System.Windows.Forms.CheckBox();
            this.tbSDT = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbMatKhau = new System.Windows.Forms.TextBox();
            this.tbTenDangNhap = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.OrangeRed;
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Controls.Add(this.label2);
            this.panelHeader.Controls.Add(this.pictureBox1);
            this.panelHeader.Controls.Add(this.lblTenTruong);
            this.panelHeader.Controls.Add(this.lblSdt);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1000, 80);
            this.panelHeader.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(90, 4);
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
            this.label2.Location = new System.Drawing.Point(802, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "SDT: 0886386654";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(10);
            this.pictureBox1.Size = new System.Drawing.Size(84, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblTenTruong
            // 
            this.lblTenTruong.AutoSize = true;
            this.lblTenTruong.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenTruong.ForeColor = System.Drawing.Color.White;
            this.lblTenTruong.Location = new System.Drawing.Point(90, 40);
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
            this.lblSdt.Location = new System.Drawing.Point(2450, 30);
            this.lblSdt.Name = "lblSdt";
            this.lblSdt.Size = new System.Drawing.Size(138, 23);
            this.lblSdt.TabIndex = 2;
            this.lblSdt.Text = "SDT: 0886386654";
            // 
            // btnDangKy
            // 
            this.btnDangKy.BackColor = System.Drawing.Color.OrangeRed;
            this.btnDangKy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangKy.ForeColor = System.Drawing.Color.White;
            this.btnDangKy.Location = new System.Drawing.Point(523, 221);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(446, 50);
            this.btnDangKy.TabIndex = 4;
            this.btnDangKy.Text = "ĐĂNG KÝ";
            this.btnDangKy.UseVisualStyleBackColor = false;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // lbDangky
            // 
            this.lbDangky.AutoSize = true;
            this.lbDangky.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDangky.Location = new System.Drawing.Point(448, 286);
            this.lbDangky.Name = "lbDangky";
            this.lbDangky.Size = new System.Drawing.Size(112, 28);
            this.lbDangky.TabIndex = 5;
            this.lbDangky.Text = "Đăng nhập";
            // 
            // lblFooter
            // 
            this.lblFooter.BackColor = System.Drawing.Color.OrangeRed;
            this.lblFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblFooter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFooter.ForeColor = System.Drawing.Color.White;
            this.lblFooter.Location = new System.Drawing.Point(0, 337);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(1000, 80);
            this.lblFooter.TabIndex = 6;
            this.lblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.OrangeRed;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(666, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(303, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "CỔNG THÔNG TIN TUYỂN SINH";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.OrangeRed;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(572, 385);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(397, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tổng đài hỗ trợ - Email: tuyensinh-daucap@hanoiedu.vn";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblFooter);
            this.panel1.Controls.Add(this.lbDangky);
            this.panel1.Controls.Add(this.btnDangKy);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 417);
            this.panel1.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbSinhVien);
            this.groupBox1.Controls.Add(this.cbPhuHuynh);
            this.groupBox1.Location = new System.Drawing.Point(30, 212);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 60);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn vai trò";
            // 
            // cbSinhVien
            // 
            this.cbSinhVien.AutoSize = true;
            this.cbSinhVien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSinhVien.Location = new System.Drawing.Point(277, 22);
            this.cbSinhVien.Name = "cbSinhVien";
            this.cbSinhVien.Size = new System.Drawing.Size(113, 32);
            this.cbSinhVien.TabIndex = 1;
            this.cbSinhVien.Text = "Sinh viên";
            this.cbSinhVien.UseVisualStyleBackColor = true;
            // 
            // cbPhuHuynh
            // 
            this.cbPhuHuynh.AutoSize = true;
            this.cbPhuHuynh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPhuHuynh.Location = new System.Drawing.Point(46, 22);
            this.cbPhuHuynh.Name = "cbPhuHuynh";
            this.cbPhuHuynh.Size = new System.Drawing.Size(126, 32);
            this.cbPhuHuynh.TabIndex = 0;
            this.cbPhuHuynh.Text = "Phụ huynh";
            this.cbPhuHuynh.UseVisualStyleBackColor = true;
            // 
            // tbSDT
            // 
            this.tbSDT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSDT.Location = new System.Drawing.Point(0, 15);
            this.tbSDT.Multiline = true;
            this.tbSDT.Name = "tbSDT";
            this.tbSDT.Size = new System.Drawing.Size(446, 34);
            this.tbSDT.TabIndex = 13;
            this.tbSDT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(6, 15);
            this.tbEmail.Multiline = true;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(446, 37);
            this.tbEmail.TabIndex = 12;
            this.tbEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbMatKhau
            // 
            this.tbMatKhau.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMatKhau.Location = new System.Drawing.Point(0, 15);
            this.tbMatKhau.Multiline = true;
            this.tbMatKhau.Name = "tbMatKhau";
            this.tbMatKhau.PasswordChar = '*';
            this.tbMatKhau.Size = new System.Drawing.Size(446, 37);
            this.tbMatKhau.TabIndex = 11;
            this.tbMatKhau.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbMatKhau.TextChanged += new System.EventHandler(this.tbMatKhau_TextChanged);
            // 
            // tbTenDangNhap
            // 
            this.tbTenDangNhap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenDangNhap.Location = new System.Drawing.Point(0, 15);
            this.tbTenDangNhap.Multiline = true;
            this.tbTenDangNhap.Name = "tbTenDangNhap";
            this.tbTenDangNhap.Size = new System.Drawing.Size(446, 37);
            this.tbTenDangNhap.TabIndex = 10;
            this.tbTenDangNhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(429, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 38);
            this.label5.TabIndex = 9;
            this.label5.Text = "Đăng ký ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbTenDangNhap);
            this.groupBox2.Location = new System.Drawing.Point(30, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 58);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tên đăng nhập";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbMatKhau);
            this.groupBox3.Location = new System.Drawing.Point(523, 62);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(446, 58);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mật khẩu";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbEmail);
            this.groupBox4.Location = new System.Drawing.Point(30, 135);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(446, 58);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Email";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tbSDT);
            this.groupBox5.Location = new System.Drawing.Point(523, 135);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(446, 58);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Số điện thoại";
            // 
            // Form2
            // 
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1000, 497);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.Text = "Đăng ký tài khoản";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelHeader;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label lblTenTruong;
        private Label lblSdt;
        private Button btnDangKy;
        private Label lbDangky;
        private Label lblFooter;
        private Label label4;
        private Label label3;
        private Panel panel1;
        private Label label5;
        private GroupBox groupBox1;
        private CheckBox cbSinhVien;
        private CheckBox cbPhuHuynh;
        private TextBox tbSDT;
        private TextBox tbEmail;
        private TextBox tbMatKhau;
        private TextBox tbTenDangNhap;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
    }
}