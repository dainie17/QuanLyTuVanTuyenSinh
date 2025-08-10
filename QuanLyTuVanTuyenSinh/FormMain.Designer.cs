using System.Drawing;
using System.Windows.Forms;

namespace QuanLyTuVanTuyenSinh
{
    partial class FormMain
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
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTenTruong = new System.Windows.Forms.Label();
            this.lblSdt = new System.Windows.Forms.Label();
            this.lblFooter = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnQuanLyUser = new System.Windows.Forms.Button();
            this.btnQuanLyCoSo = new System.Windows.Forms.Button();
            this.btnQuanLyNganh = new System.Windows.Forms.Button();
            this.btnQuanLyTuyenSinh = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnDangKyTkSv = new System.Windows.Forms.Button();
            this.btnQuanLySv = new System.Windows.Forms.Button();
            this.btnDangKyTuyenSinh = new System.Windows.Forms.Button();
            this.btnNganhHoc = new System.Windows.Forms.Button();
            this.btnXemKetQua = new System.Windows.Forms.Button();
            this.btnCapNhatTk = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.OrangeRed;
            this.panelHeader.Controls.Add(this.label7);
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
            this.panelHeader.TabIndex = 5;
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(952, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 34);
            this.label7.TabIndex = 7;
            this.label7.Text = "X";
            this.label7.Click += new System.EventHandler(this.label7_Click);
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
            this.label2.Location = new System.Drawing.Point(764, 19);
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
            this.lblSdt.Location = new System.Drawing.Point(3250, 24);
            this.lblSdt.Name = "lblSdt";
            this.lblSdt.Size = new System.Drawing.Size(138, 23);
            this.lblSdt.TabIndex = 2;
            this.lblSdt.Text = "SDT: 0886386654";
            // 
            // lblFooter
            // 
            this.lblFooter.BackColor = System.Drawing.Color.OrangeRed;
            this.lblFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblFooter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFooter.ForeColor = System.Drawing.Color.White;
            this.lblFooter.Location = new System.Drawing.Point(0, 432);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(1000, 64);
            this.lblFooter.TabIndex = 7;
            this.lblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.OrangeRed;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(668, 438);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(303, 28);
            this.label4.TabIndex = 8;
            this.label4.Text = "CỔNG THÔNG TIN TUYỂN SINH";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.OrangeRed;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(574, 470);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(397, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tổng đài hỗ trợ - Email: tuyensinh-daucap@hanoiedu.vn";
            // 
            // btnQuanLyUser
            // 
            this.btnQuanLyUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnQuanLyUser.BackColor = System.Drawing.Color.OrangeRed;
            this.btnQuanLyUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyUser.ForeColor = System.Drawing.Color.White;
            this.btnQuanLyUser.Location = new System.Drawing.Point(10, 101);
            this.btnQuanLyUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuanLyUser.Name = "btnQuanLyUser";
            this.btnQuanLyUser.Size = new System.Drawing.Size(419, 40);
            this.btnQuanLyUser.TabIndex = 10;
            this.btnQuanLyUser.Text = "Quản lý người dùng";
            this.btnQuanLyUser.UseVisualStyleBackColor = false;
            this.btnQuanLyUser.Click += new System.EventHandler(this.btnQuanLyUser_Click);
            // 
            // btnQuanLyCoSo
            // 
            this.btnQuanLyCoSo.BackColor = System.Drawing.Color.OrangeRed;
            this.btnQuanLyCoSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyCoSo.ForeColor = System.Drawing.Color.White;
            this.btnQuanLyCoSo.Location = new System.Drawing.Point(10, 146);
            this.btnQuanLyCoSo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuanLyCoSo.Name = "btnQuanLyCoSo";
            this.btnQuanLyCoSo.Size = new System.Drawing.Size(419, 40);
            this.btnQuanLyCoSo.TabIndex = 11;
            this.btnQuanLyCoSo.Text = "Quản lý cơ sở";
            this.btnQuanLyCoSo.UseVisualStyleBackColor = false;
            this.btnQuanLyCoSo.Click += new System.EventHandler(this.btnQuanLyCoSo_Click);
            // 
            // btnQuanLyNganh
            // 
            this.btnQuanLyNganh.BackColor = System.Drawing.Color.OrangeRed;
            this.btnQuanLyNganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyNganh.ForeColor = System.Drawing.Color.White;
            this.btnQuanLyNganh.Location = new System.Drawing.Point(10, 190);
            this.btnQuanLyNganh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuanLyNganh.Name = "btnQuanLyNganh";
            this.btnQuanLyNganh.Size = new System.Drawing.Size(419, 40);
            this.btnQuanLyNganh.TabIndex = 12;
            this.btnQuanLyNganh.Text = "Quản lý ngành học";
            this.btnQuanLyNganh.UseVisualStyleBackColor = false;
            this.btnQuanLyNganh.Click += new System.EventHandler(this.btnQuanLyNganh_Click);
            // 
            // btnQuanLyTuyenSinh
            // 
            this.btnQuanLyTuyenSinh.BackColor = System.Drawing.Color.OrangeRed;
            this.btnQuanLyTuyenSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyTuyenSinh.ForeColor = System.Drawing.Color.White;
            this.btnQuanLyTuyenSinh.Location = new System.Drawing.Point(10, 234);
            this.btnQuanLyTuyenSinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuanLyTuyenSinh.Name = "btnQuanLyTuyenSinh";
            this.btnQuanLyTuyenSinh.Size = new System.Drawing.Size(419, 40);
            this.btnQuanLyTuyenSinh.TabIndex = 14;
            this.btnQuanLyTuyenSinh.Text = "Danh sách hồ sơ tuyển sinh";
            this.btnQuanLyTuyenSinh.UseVisualStyleBackColor = false;
            this.btnQuanLyTuyenSinh.Click += new System.EventHandler(this.btnQuanLyTuyenSinh_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.OrangeRed;
            this.btnDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ForeColor = System.Drawing.Color.White;
            this.btnDangXuat.Location = new System.Drawing.Point(10, 366);
            this.btnDangXuat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(419, 40);
            this.btnDangXuat.TabIndex = 15;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnDangKyTkSv
            // 
            this.btnDangKyTkSv.BackColor = System.Drawing.Color.OrangeRed;
            this.btnDangKyTkSv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangKyTkSv.ForeColor = System.Drawing.Color.White;
            this.btnDangKyTkSv.Location = new System.Drawing.Point(12, 278);
            this.btnDangKyTkSv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDangKyTkSv.Name = "btnDangKyTkSv";
            this.btnDangKyTkSv.Size = new System.Drawing.Size(419, 40);
            this.btnDangKyTkSv.TabIndex = 16;
            this.btnDangKyTkSv.Text = "Tạo tài khoản cho sinh viên";
            this.btnDangKyTkSv.UseVisualStyleBackColor = false;
            this.btnDangKyTkSv.Click += new System.EventHandler(this.btnDangKyTkSv_Click);
            // 
            // btnQuanLySv
            // 
            this.btnQuanLySv.BackColor = System.Drawing.Color.OrangeRed;
            this.btnQuanLySv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLySv.ForeColor = System.Drawing.Color.White;
            this.btnQuanLySv.Location = new System.Drawing.Point(12, 322);
            this.btnQuanLySv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuanLySv.Name = "btnQuanLySv";
            this.btnQuanLySv.Size = new System.Drawing.Size(419, 40);
            this.btnQuanLySv.TabIndex = 17;
            this.btnQuanLySv.Text = "Quản lý tài khoản sinh viên";
            this.btnQuanLySv.UseVisualStyleBackColor = false;
            this.btnQuanLySv.Click += new System.EventHandler(this.btnQuanLySv_Click);
            // 
            // btnDangKyTuyenSinh
            // 
            this.btnDangKyTuyenSinh.BackColor = System.Drawing.Color.OrangeRed;
            this.btnDangKyTuyenSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangKyTuyenSinh.ForeColor = System.Drawing.Color.White;
            this.btnDangKyTuyenSinh.Location = new System.Drawing.Point(10, 145);
            this.btnDangKyTuyenSinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDangKyTuyenSinh.Name = "btnDangKyTuyenSinh";
            this.btnDangKyTuyenSinh.Size = new System.Drawing.Size(419, 40);
            this.btnDangKyTuyenSinh.TabIndex = 18;
            this.btnDangKyTuyenSinh.Text = "Đăng ký tuyển sinh";
            this.btnDangKyTuyenSinh.UseVisualStyleBackColor = false;
            this.btnDangKyTuyenSinh.Click += new System.EventHandler(this.btnDangKyTuyenSinh_Click);
            // 
            // btnNganhHoc
            // 
            this.btnNganhHoc.BackColor = System.Drawing.Color.OrangeRed;
            this.btnNganhHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNganhHoc.ForeColor = System.Drawing.Color.White;
            this.btnNganhHoc.Location = new System.Drawing.Point(10, 99);
            this.btnNganhHoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNganhHoc.Name = "btnNganhHoc";
            this.btnNganhHoc.Size = new System.Drawing.Size(419, 40);
            this.btnNganhHoc.TabIndex = 19;
            this.btnNganhHoc.Text = "Xem ngành học";
            this.btnNganhHoc.UseVisualStyleBackColor = false;
            this.btnNganhHoc.Click += new System.EventHandler(this.btnNganhHoc_Click);
            // 
            // btnXemKetQua
            // 
            this.btnXemKetQua.BackColor = System.Drawing.Color.OrangeRed;
            this.btnXemKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemKetQua.ForeColor = System.Drawing.Color.White;
            this.btnXemKetQua.Location = new System.Drawing.Point(10, 190);
            this.btnXemKetQua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXemKetQua.Name = "btnXemKetQua";
            this.btnXemKetQua.Size = new System.Drawing.Size(419, 40);
            this.btnXemKetQua.TabIndex = 21;
            this.btnXemKetQua.Text = "Xem kết quả tuyển sinh";
            this.btnXemKetQua.UseVisualStyleBackColor = false;
            this.btnXemKetQua.Click += new System.EventHandler(this.btnXemKetQua_Click);
            // 
            // btnCapNhatTk
            // 
            this.btnCapNhatTk.BackColor = System.Drawing.Color.OrangeRed;
            this.btnCapNhatTk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatTk.ForeColor = System.Drawing.Color.White;
            this.btnCapNhatTk.Location = new System.Drawing.Point(12, 234);
            this.btnCapNhatTk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCapNhatTk.Name = "btnCapNhatTk";
            this.btnCapNhatTk.Size = new System.Drawing.Size(419, 40);
            this.btnCapNhatTk.TabIndex = 22;
            this.btnCapNhatTk.Text = "Cập nhật thông tin cá nhân";
            this.btnCapNhatTk.UseVisualStyleBackColor = false;
            this.btnCapNhatTk.Click += new System.EventHandler(this.btnCapNhatTk_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(711, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(260, 38);
            this.label5.TabIndex = 23;
            this.label5.Text = "CỔNG THÔNG TIN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(596, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(375, 75);
            this.label6.TabIndex = 24;
            this.label6.Text = "Các ngành học bắt kịp xu hướng tuyển dụng, \nphù hợp với nhu cầu nhân lực tại các " +
    "khu vực\n phát triển du lịch, dịch vụ và công nghệ cao";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::QuanLyTuVanTuyenSinh.Properties.Resources.z6852218318795_47a6ff3d7d0353bc27ab88156c44397b;
            this.pictureBox2.Location = new System.Drawing.Point(466, 234);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(505, 191);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.OrangeRed;
            this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.Location = new System.Drawing.Point(12, 278);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(419, 40);
            this.btnThongKe.TabIndex = 0;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Visible = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 496);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.btnCapNhatTk);
            this.Controls.Add(this.btnXemKetQua);
            this.Controls.Add(this.btnNganhHoc);
            this.Controls.Add(this.btnDangKyTuyenSinh);
            this.Controls.Add(this.btnQuanLySv);
            this.Controls.Add(this.btnDangKyTkSv);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.btnQuanLyTuyenSinh);
            this.Controls.Add(this.btnQuanLyNganh);
            this.Controls.Add(this.btnQuanLyCoSo);
            this.Controls.Add(this.btnQuanLyUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblFooter);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private Label lblFooter;
        private Label label4;
        private Label label3;
        private Button btnQuanLyUser;
        private Button btnQuanLyCoSo;
        private Button btnQuanLyNganh;
        private Button btnQuanLyTuyenSinh;
        private Button btnDangXuat;
        private Button btnDangKyTkSv;
        private Button btnQuanLySv;
        private Button btnDangKyTuyenSinh;
        private Button btnNganhHoc;
        private Button btnXemKetQua;
        private Button btnCapNhatTk;
        private Label label5;
        private Label label6;
        private Label label7;
        private PictureBox pictureBox2;
        private Button btnThongKe;
    }
}