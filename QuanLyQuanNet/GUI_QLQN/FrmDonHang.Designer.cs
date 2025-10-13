namespace GUI_QLQN
{
    partial class FrmDonHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label7 = new System.Windows.Forms.Label();
            this.btnTimKiem = new Guna.UI2.WinForms.Guna2Button();
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvQLDH = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtMaKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtpThoiGianDat = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTongTien = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtpNgayDatHang = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMaDH = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLDH)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(29, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(212, 45);
            this.label7.TabIndex = 19;
            this.label7.Text = "DANH SÁCH";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTimKiem.Animated = true;
            this.btnTimKiem.BackColor = System.Drawing.Color.Transparent;
            this.btnTimKiem.BorderRadius = 10;
            this.btnTimKiem.BorderThickness = 2;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(828, 33);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(173, 47);
            this.btnTimKiem.TabIndex = 18;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseTransparentBackground = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTimKiem.Animated = true;
            this.txtTimKiem.BorderColor = System.Drawing.Color.Black;
            this.txtTimKiem.BorderThickness = 2;
            this.txtTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiem.DefaultText = "";
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtTimKiem.Location = new System.Drawing.Point(377, 36);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtTimKiem.PlaceholderText = "Tìm kiếm theo Mã Đơn";
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.Size = new System.Drawing.Size(372, 44);
            this.txtTimKiem.TabIndex = 17;
            // 
            // dgvQLDH
            // 
            this.dgvQLDH.AllowUserToAddRows = false;
            this.dgvQLDH.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvQLDH.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvQLDH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQLDH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvQLDH.ColumnHeadersHeight = 50;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvQLDH.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvQLDH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvQLDH.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvQLDH.Location = new System.Drawing.Point(0, 107);
            this.dgvQLDH.Name = "dgvQLDH";
            this.dgvQLDH.ReadOnly = true;
            this.dgvQLDH.RowHeadersVisible = false;
            this.dgvQLDH.RowHeadersWidth = 62;
            this.dgvQLDH.RowTemplate.Height = 50;
            this.dgvQLDH.Size = new System.Drawing.Size(1164, 778);
            this.dgvQLDH.TabIndex = 16;
            this.dgvQLDH.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvQLDH.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvQLDH.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvQLDH.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvQLDH.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvQLDH.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvQLDH.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvQLDH.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgvQLDH.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvQLDH.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.dgvQLDH.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvQLDH.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvQLDH.ThemeStyle.HeaderStyle.Height = 50;
            this.dgvQLDH.ThemeStyle.ReadOnly = true;
            this.dgvQLDH.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvQLDH.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvQLDH.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.dgvQLDH.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvQLDH.ThemeStyle.RowsStyle.Height = 50;
            this.dgvQLDH.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.LightBlue;
            this.dgvQLDH.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvQLDH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQLDH_CellClick);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.White;
            this.guna2Panel2.Controls.Add(this.dgvQLDH);
            this.guna2Panel2.Controls.Add(this.guna2GroupBox1);
            this.guna2Panel2.Controls.Add(this.guna2Panel1);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1548, 885);
            this.guna2Panel2.TabIndex = 20;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaKH.Animated = true;
            this.txtMaKH.BorderColor = System.Drawing.Color.Black;
            this.txtMaKH.BorderThickness = 2;
            this.txtMaKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaKH.DefaultText = "";
            this.txtMaKH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaKH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaKH.Location = new System.Drawing.Point(21, 158);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtMaKH.PlaceholderText = "";
            this.txtMaKH.SelectedText = "";
            this.txtMaKH.Size = new System.Drawing.Size(346, 33);
            this.txtMaKH.TabIndex = 62;
            // 
            // dtpThoiGianDat
            // 
            this.dtpThoiGianDat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpThoiGianDat.Checked = true;
            this.dtpThoiGianDat.FillColor = System.Drawing.Color.Silver;
            this.dtpThoiGianDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpThoiGianDat.ForeColor = System.Drawing.Color.Black;
            this.dtpThoiGianDat.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpThoiGianDat.Location = new System.Drawing.Point(21, 312);
            this.dtpThoiGianDat.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpThoiGianDat.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpThoiGianDat.Name = "dtpThoiGianDat";
            this.dtpThoiGianDat.Size = new System.Drawing.Size(346, 33);
            this.dtpThoiGianDat.TabIndex = 61;
            this.dtpThoiGianDat.Value = new System.DateTime(2025, 7, 6, 21, 7, 21, 633);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(17, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 60;
            this.label1.Text = "Thời Gian Đặt :";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTongTien.Animated = true;
            this.txtTongTien.BorderColor = System.Drawing.Color.Black;
            this.txtTongTien.BorderThickness = 2;
            this.txtTongTien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTongTien.DefaultText = "";
            this.txtTongTien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTongTien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTongTien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTongTien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTongTien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTongTien.Location = new System.Drawing.Point(21, 238);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtTongTien.PlaceholderText = "";
            this.txtTongTien.SelectedText = "";
            this.txtTongTien.Size = new System.Drawing.Size(346, 33);
            this.txtTongTien.TabIndex = 58;
            // 
            // dtpNgayDatHang
            // 
            this.dtpNgayDatHang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpNgayDatHang.Checked = true;
            this.dtpNgayDatHang.FillColor = System.Drawing.Color.Silver;
            this.dtpNgayDatHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayDatHang.ForeColor = System.Drawing.Color.Black;
            this.dtpNgayDatHang.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayDatHang.Location = new System.Drawing.Point(21, 391);
            this.dtpNgayDatHang.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayDatHang.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayDatHang.Name = "dtpNgayDatHang";
            this.dtpNgayDatHang.Size = new System.Drawing.Size(346, 33);
            this.dtpNgayDatHang.TabIndex = 56;
            this.dtpNgayDatHang.Value = new System.DateTime(2025, 7, 6, 21, 7, 21, 633);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(22, 368);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 20);
            this.label13.TabIndex = 53;
            this.label13.Text = "Ngày Đặt :";
            // 
            // txtMaDH
            // 
            this.txtMaDH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaDH.Animated = true;
            this.txtMaDH.BorderColor = System.Drawing.Color.Black;
            this.txtMaDH.BorderThickness = 2;
            this.txtMaDH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaDH.DefaultText = "";
            this.txtMaDH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaDH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaDH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaDH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaDH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaDH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaDH.Location = new System.Drawing.Point(21, 76);
            this.txtMaDH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaDH.Name = "txtMaDH";
            this.txtMaDH.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtMaDH.PlaceholderText = "";
            this.txtMaDH.SelectedText = "";
            this.txtMaDH.Size = new System.Drawing.Size(346, 33);
            this.txtMaDH.TabIndex = 51;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(22, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 20);
            this.label8.TabIndex = 50;
            this.label8.Text = "Tổng tiền :";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(17, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 48;
            this.label2.Text = "Mã Khách :";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(17, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 49;
            this.label3.Text = "Mã Đơn :";
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.label3);
            this.guna2GroupBox1.Controls.Add(this.txtMaKH);
            this.guna2GroupBox1.Controls.Add(this.label2);
            this.guna2GroupBox1.Controls.Add(this.dtpThoiGianDat);
            this.guna2GroupBox1.Controls.Add(this.label8);
            this.guna2GroupBox1.Controls.Add(this.label1);
            this.guna2GroupBox1.Controls.Add(this.txtMaDH);
            this.guna2GroupBox1.Controls.Add(this.txtTongTien);
            this.guna2GroupBox1.Controls.Add(this.label13);
            this.guna2GroupBox1.Controls.Add(this.dtpNgayDatHang);
            this.guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(1164, 107);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(384, 778);
            this.guna2GroupBox1.TabIndex = 63;
            this.guna2GroupBox1.Text = "Thông tin";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.btnTimKiem);
            this.guna2Panel1.Controls.Add(this.txtTimKiem);
            this.guna2Panel1.Controls.Add(this.label7);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1548, 107);
            this.guna2Panel1.TabIndex = 64;
            // 
            // FrmDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(1548, 885);
            this.Controls.Add(this.guna2Panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDonHang";
            this.Text = "FrmDonHang";
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLDH)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button btnTimKiem;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private Guna.UI2.WinForms.Guna2DataGridView dgvQLDH;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2TextBox txtTongTien;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayDatHang;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2TextBox txtMaDH;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpThoiGianDat;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtMaKH;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}