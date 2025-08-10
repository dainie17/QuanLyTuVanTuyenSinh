namespace QuanLyTuVanTuyenSinh
{
    partial class FormThongKe
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTenTruong = new System.Windows.Forms.Label();
            this.lblSdt = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFooter = new System.Windows.Forms.Label();
            this.gruop = new System.Windows.Forms.GroupBox();
            this.cboMajor = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboCampus = new System.Windows.Forms.ComboBox();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panelSummaryCards = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPayFailed = new System.Windows.Forms.Label();
            this.lblPayPending = new System.Windows.Forms.Label();
            this.lblPaid = new System.Windows.Forms.Label();
            this.lblPending = new System.Windows.Forms.Label();
            this.lblFail = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.chartByMajor = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartByCampus = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gruop.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panelSummaryCards.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartByMajor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartByCampus)).BeginInit();
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
            this.panelHeader.Size = new System.Drawing.Size(1003, 64);
            this.panelHeader.TabIndex = 7;
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
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            this.lblSdt.Location = new System.Drawing.Point(4053, 24);
            this.lblSdt.Name = "lblSdt";
            this.lblSdt.Size = new System.Drawing.Size(138, 23);
            this.lblSdt.TabIndex = 2;
            this.lblSdt.Text = "SDT: 0886386654";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(421, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 38);
            this.label5.TabIndex = 14;
            this.label5.Text = "Thống kê";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.OrangeRed;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(591, 836);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(397, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Tổng đài hỗ trợ - Email: tuyensinh-daucap@hanoiedu.vn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.OrangeRed;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(685, 803);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(303, 28);
            this.label4.TabIndex = 16;
            this.label4.Text = "CỔNG THÔNG TIN TUYỂN SINH";
            // 
            // lblFooter
            // 
            this.lblFooter.BackColor = System.Drawing.Color.OrangeRed;
            this.lblFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblFooter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFooter.ForeColor = System.Drawing.Color.White;
            this.lblFooter.Location = new System.Drawing.Point(0, 796);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(1003, 64);
            this.lblFooter.TabIndex = 15;
            this.lblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gruop
            // 
            this.gruop.Controls.Add(this.cboMajor);
            this.gruop.Location = new System.Drawing.Point(583, 118);
            this.gruop.Name = "gruop";
            this.gruop.Size = new System.Drawing.Size(408, 52);
            this.gruop.TabIndex = 20;
            this.gruop.TabStop = false;
            this.gruop.Text = "Chọn ngành học";
            // 
            // cboMajor
            // 
            this.cboMajor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMajor.FormattingEnabled = true;
            this.cboMajor.Location = new System.Drawing.Point(0, 17);
            this.cboMajor.Name = "cboMajor";
            this.cboMajor.Size = new System.Drawing.Size(408, 33);
            this.cboMajor.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboCampus);
            this.groupBox1.Location = new System.Drawing.Point(12, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 52);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn cơ sở";
            // 
            // cboCampus
            // 
            this.cboCampus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCampus.FormattingEnabled = true;
            this.cboCampus.Location = new System.Drawing.Point(0, 17);
            this.cboCampus.Name = "cboCampus";
            this.cboCampus.Size = new System.Drawing.Size(408, 33);
            this.cboCampus.TabIndex = 18;
            this.cboCampus.SelectedIndexChanged += new System.EventHandler(this.cboCampus_SelectedIndexChanged);
            // 
            // dtFrom
            // 
            this.dtFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFrom.Location = new System.Drawing.Point(6, 16);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(396, 30);
            this.dtFrom.TabIndex = 21;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtFrom);
            this.groupBox2.Location = new System.Drawing.Point(12, 176);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(408, 52);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ngày đầu";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtTo);
            this.groupBox3.Location = new System.Drawing.Point(583, 176);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(408, 52);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ngày cuối";
            // 
            // dtTo
            // 
            this.dtTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtTo.Location = new System.Drawing.Point(4, 16);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(404, 30);
            this.dtTo.TabIndex = 21;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.OrangeRed;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(12, 234);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(408, 45);
            this.btnRefresh.TabIndex = 23;
            this.btnRefresh.Text = "Load dữ liệu";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // panelSummaryCards
            // 
            this.panelSummaryCards.Controls.Add(this.label13);
            this.panelSummaryCards.Controls.Add(this.label12);
            this.panelSummaryCards.Controls.Add(this.label11);
            this.panelSummaryCards.Controls.Add(this.label10);
            this.panelSummaryCards.Controls.Add(this.label9);
            this.panelSummaryCards.Controls.Add(this.label8);
            this.panelSummaryCards.Controls.Add(this.label7);
            this.panelSummaryCards.Controls.Add(this.lblPayFailed);
            this.panelSummaryCards.Controls.Add(this.lblPayPending);
            this.panelSummaryCards.Controls.Add(this.lblPaid);
            this.panelSummaryCards.Controls.Add(this.lblPending);
            this.panelSummaryCards.Controls.Add(this.lblFail);
            this.panelSummaryCards.Controls.Add(this.lblPass);
            this.panelSummaryCards.Controls.Add(this.lblTotal);
            this.panelSummaryCards.Location = new System.Drawing.Point(18, 286);
            this.panelSummaryCards.Name = "panelSummaryCards";
            this.panelSummaryCards.Size = new System.Drawing.Size(970, 140);
            this.panelSummaryCards.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(465, 99);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(290, 25);
            this.label13.TabIndex = 13;
            this.label13.Text = "Số sinh viên thanh toán thất bại:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(465, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(403, 25);
            this.label12.TabIndex = 12;
            this.label12.Text = "Số sinh viên chưa được xác nhận thanh toán:\r\n";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(465, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(249, 25);
            this.label11.TabIndex = 11;
            this.label11.Text = "Số sinh viên đã thanh toán:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(258, 25);
            this.label10.TabIndex = 10;
            this.label10.Text = "Số sinh viên chưa xác nhận:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 25);
            this.label9.TabIndex = 9;
            this.label9.Text = "Số sinh viên rớt:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 25);
            this.label8.TabIndex = 8;
            this.label8.Text = "Số sinh viên đậu:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Tổng sinh viên:";
            // 
            // lblPayFailed
            // 
            this.lblPayFailed.AutoSize = true;
            this.lblPayFailed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayFailed.Location = new System.Drawing.Point(892, 99);
            this.lblPayFailed.Name = "lblPayFailed";
            this.lblPayFailed.Size = new System.Drawing.Size(75, 25);
            this.lblPayFailed.TabIndex = 6;
            this.lblPayFailed.Text = "label13";
            // 
            // lblPayPending
            // 
            this.lblPayPending.AutoSize = true;
            this.lblPayPending.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayPending.Location = new System.Drawing.Point(892, 55);
            this.lblPayPending.Name = "lblPayPending";
            this.lblPayPending.Size = new System.Drawing.Size(75, 25);
            this.lblPayPending.TabIndex = 5;
            this.lblPayPending.Text = "label12";
            // 
            // lblPaid
            // 
            this.lblPaid.AutoSize = true;
            this.lblPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaid.Location = new System.Drawing.Point(892, 15);
            this.lblPaid.Name = "lblPaid";
            this.lblPaid.Size = new System.Drawing.Size(75, 25);
            this.lblPaid.TabIndex = 4;
            this.lblPaid.Text = "label11";
            // 
            // lblPending
            // 
            this.lblPending.AutoSize = true;
            this.lblPending.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPending.Location = new System.Drawing.Point(282, 99);
            this.lblPending.Name = "lblPending";
            this.lblPending.Size = new System.Drawing.Size(75, 25);
            this.lblPending.TabIndex = 3;
            this.lblPending.Text = "label10";
            // 
            // lblFail
            // 
            this.lblFail.AutoSize = true;
            this.lblFail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFail.Location = new System.Drawing.Point(282, 71);
            this.lblFail.Name = "lblFail";
            this.lblFail.Size = new System.Drawing.Size(64, 25);
            this.lblFail.TabIndex = 2;
            this.lblFail.Text = "label9";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(282, 43);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(64, 25);
            this.lblPass.TabIndex = 1;
            this.lblPass.Text = "label8";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(282, 15);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(64, 25);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "label7";
            // 
            // chartByMajor
            // 
            chartArea1.Name = "ChartArea1";
            this.chartByMajor.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartByMajor.Legends.Add(legend1);
            this.chartByMajor.Location = new System.Drawing.Point(509, 432);
            this.chartByMajor.Name = "chartByMajor";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartByMajor.Series.Add(series1);
            this.chartByMajor.Size = new System.Drawing.Size(479, 356);
            this.chartByMajor.TabIndex = 25;
            this.chartByMajor.Text = "chart1";
            // 
            // chartByCampus
            // 
            chartArea2.Name = "ChartArea1";
            this.chartByCampus.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartByCampus.Legends.Add(legend2);
            this.chartByCampus.Location = new System.Drawing.Point(18, 432);
            this.chartByCampus.Name = "chartByCampus";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartByCampus.Series.Add(series2);
            this.chartByCampus.Size = new System.Drawing.Size(465, 356);
            this.chartByCampus.TabIndex = 25;
            this.chartByCampus.Text = "chart1";
            // 
            // FormThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 860);
            this.Controls.Add(this.chartByCampus);
            this.Controls.Add(this.chartByMajor);
            this.Controls.Add(this.panelSummaryCards);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gruop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblFooter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormThongKe";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gruop.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.panelSummaryCards.ResumeLayout(false);
            this.panelSummaryCards.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartByMajor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartByCampus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTenTruong;
        private System.Windows.Forms.Label lblSdt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.GroupBox gruop;
        private System.Windows.Forms.ComboBox cboMajor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboCampus;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel panelSummaryCards;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartByMajor;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartByCampus;
        private System.Windows.Forms.Label lblPayFailed;
        private System.Windows.Forms.Label lblPayPending;
        private System.Windows.Forms.Label lblPaid;
        private System.Windows.Forms.Label lblPending;
        private System.Windows.Forms.Label lblFail;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
    }
}