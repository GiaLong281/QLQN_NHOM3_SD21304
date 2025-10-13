namespace GUI_QLQN
{
    partial class FrmDichVu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvQuanLyDichVu = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dtpNgayTao = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnSua = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnXoa = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnLamMoi = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnThem = new Guna.UI2.WinForms.Guna2GradientButton();
            this.cboMaLoaiDichVu = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDonGia = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenDichVu = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMaDichVu = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnTimkiem = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtTKMT = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.pbAnhSP = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnChon = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyDichVu)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnhSP)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvQuanLyDichVu
            // 
            this.dgvQuanLyDichVu.AllowUserToAddRows = false;
            this.dgvQuanLyDichVu.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgvQuanLyDichVu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvQuanLyDichVu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQuanLyDichVu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvQuanLyDichVu.ColumnHeadersHeight = 50;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvQuanLyDichVu.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvQuanLyDichVu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvQuanLyDichVu.Location = new System.Drawing.Point(0, 107);
            this.dgvQuanLyDichVu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvQuanLyDichVu.Name = "dgvQuanLyDichVu";
            this.dgvQuanLyDichVu.ReadOnly = true;
            this.dgvQuanLyDichVu.RowHeadersVisible = false;
            this.dgvQuanLyDichVu.RowHeadersWidth = 51;
            this.dgvQuanLyDichVu.RowTemplate.Height = 50;
            this.dgvQuanLyDichVu.Size = new System.Drawing.Size(1130, 778);
            this.dgvQuanLyDichVu.TabIndex = 1;
            this.dgvQuanLyDichVu.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvQuanLyDichVu.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvQuanLyDichVu.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvQuanLyDichVu.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvQuanLyDichVu.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvQuanLyDichVu.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvQuanLyDichVu.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvQuanLyDichVu.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvQuanLyDichVu.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvQuanLyDichVu.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.dgvQuanLyDichVu.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvQuanLyDichVu.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvQuanLyDichVu.ThemeStyle.HeaderStyle.Height = 50;
            this.dgvQuanLyDichVu.ThemeStyle.ReadOnly = true;
            this.dgvQuanLyDichVu.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvQuanLyDichVu.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvQuanLyDichVu.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.dgvQuanLyDichVu.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvQuanLyDichVu.ThemeStyle.RowsStyle.Height = 50;
            this.dgvQuanLyDichVu.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvQuanLyDichVu.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvQuanLyDichVu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuanLyDichVu_CellClick);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2GroupBox1.Controls.Add(this.btnChon);
            this.guna2GroupBox1.Controls.Add(this.pbAnhSP);
            this.guna2GroupBox1.Controls.Add(this.dtpNgayTao);
            this.guna2GroupBox1.Controls.Add(this.btnSua);
            this.guna2GroupBox1.Controls.Add(this.btnXoa);
            this.guna2GroupBox1.Controls.Add(this.btnLamMoi);
            this.guna2GroupBox1.Controls.Add(this.btnThem);
            this.guna2GroupBox1.Controls.Add(this.cboMaLoaiDichVu);
            this.guna2GroupBox1.Controls.Add(this.label2);
            this.guna2GroupBox1.Controls.Add(this.label6);
            this.guna2GroupBox1.Controls.Add(this.label4);
            this.guna2GroupBox1.Controls.Add(this.label3);
            this.guna2GroupBox1.Controls.Add(this.label5);
            this.guna2GroupBox1.Controls.Add(this.txtDonGia);
            this.guna2GroupBox1.Controls.Add(this.txtTenDichVu);
            this.guna2GroupBox1.Controls.Add(this.txtMaDichVu);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(1130, 107);
            this.guna2GroupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(418, 778);
            this.guna2GroupBox1.TabIndex = 2;
            this.guna2GroupBox1.Text = "Thông Tin";
            this.guna2GroupBox1.Click += new System.EventHandler(this.guna2GroupBox1_Click);
            // 
            // dtpNgayTao
            // 
            this.dtpNgayTao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpNgayTao.BorderThickness = 2;
            this.dtpNgayTao.Checked = true;
            this.dtpNgayTao.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayTao.ForeColor = System.Drawing.Color.White;
            this.dtpNgayTao.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpNgayTao.Location = new System.Drawing.Point(14, 451);
            this.dtpNgayTao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpNgayTao.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayTao.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayTao.Name = "dtpNgayTao";
            this.dtpNgayTao.Size = new System.Drawing.Size(286, 36);
            this.dtpNgayTao.TabIndex = 3;
            this.dtpNgayTao.Value = new System.DateTime(2025, 7, 6, 10, 1, 2, 127);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua.Animated = true;
            this.btnSua.BackColor = System.Drawing.Color.Transparent;
            this.btnSua.BorderRadius = 10;
            this.btnSua.BorderThickness = 2;
            this.btnSua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSua.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSua.FillColor = System.Drawing.Color.DarkKhaki;
            this.btnSua.FillColor2 = System.Drawing.Color.GreenYellow;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(110, 739);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(96, 35);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseTransparentBackground = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.Animated = true;
            this.btnXoa.BackColor = System.Drawing.Color.Transparent;
            this.btnXoa.BorderRadius = 10;
            this.btnXoa.BorderThickness = 2;
            this.btnXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoa.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoa.FillColor = System.Drawing.Color.Brown;
            this.btnXoa.FillColor2 = System.Drawing.Color.DeepPink;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(215, 739);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(96, 35);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseTransparentBackground = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLamMoi.Animated = true;
            this.btnLamMoi.BackColor = System.Drawing.Color.Transparent;
            this.btnLamMoi.BorderRadius = 10;
            this.btnLamMoi.BorderThickness = 2;
            this.btnLamMoi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLamMoi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLamMoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLamMoi.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLamMoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLamMoi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnLamMoi.FillColor2 = System.Drawing.Color.GreenYellow;
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(319, 739);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(96, 35);
            this.btnLamMoi.TabIndex = 2;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseTransparentBackground = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.Animated = true;
            this.btnThem.BackColor = System.Drawing.Color.Transparent;
            this.btnThem.BorderRadius = 10;
            this.btnThem.BorderThickness = 2;
            this.btnThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThem.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThem.FillColor = System.Drawing.Color.Blue;
            this.btnThem.FillColor2 = System.Drawing.Color.DeepSkyBlue;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(6, 739);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(96, 35);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseTransparentBackground = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cboMaLoaiDichVu
            // 
            this.cboMaLoaiDichVu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboMaLoaiDichVu.BackColor = System.Drawing.Color.Transparent;
            this.cboMaLoaiDichVu.BorderColor = System.Drawing.Color.Black;
            this.cboMaLoaiDichVu.BorderThickness = 2;
            this.cboMaLoaiDichVu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboMaLoaiDichVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaLoaiDichVu.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboMaLoaiDichVu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboMaLoaiDichVu.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaLoaiDichVu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboMaLoaiDichVu.ItemHeight = 30;
            this.cboMaLoaiDichVu.Location = new System.Drawing.Point(13, 271);
            this.cboMaLoaiDichVu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboMaLoaiDichVu.Name = "cboMaLoaiDichVu";
            this.cboMaLoaiDichVu.Size = new System.Drawing.Size(287, 36);
            this.cboMaLoaiDichVu.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(10, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Dịch Vụ :";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(10, 426);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "Ngày Tạo";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(10, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Đơn Giá";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(10, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Loại Dịch Vụ ";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(10, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "Mã Dịch Vụ :";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDonGia.Animated = true;
            this.txtDonGia.BorderColor = System.Drawing.Color.Black;
            this.txtDonGia.BorderThickness = 2;
            this.txtDonGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDonGia.DefaultText = "";
            this.txtDonGia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDonGia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDonGia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDonGia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDonGia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDonGia.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDonGia.Location = new System.Drawing.Point(13, 363);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.PlaceholderText = "";
            this.txtDonGia.SelectedText = "";
            this.txtDonGia.Size = new System.Drawing.Size(287, 36);
            this.txtDonGia.TabIndex = 0;
            // 
            // txtTenDichVu
            // 
            this.txtTenDichVu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenDichVu.Animated = true;
            this.txtTenDichVu.BorderColor = System.Drawing.Color.Black;
            this.txtTenDichVu.BorderThickness = 2;
            this.txtTenDichVu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenDichVu.DefaultText = "";
            this.txtTenDichVu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenDichVu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenDichVu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenDichVu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenDichVu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenDichVu.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDichVu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenDichVu.Location = new System.Drawing.Point(13, 186);
            this.txtTenDichVu.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtTenDichVu.Name = "txtTenDichVu";
            this.txtTenDichVu.PlaceholderText = "";
            this.txtTenDichVu.SelectedText = "";
            this.txtTenDichVu.Size = new System.Drawing.Size(287, 36);
            this.txtTenDichVu.TabIndex = 0;
            // 
            // txtMaDichVu
            // 
            this.txtMaDichVu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaDichVu.Animated = true;
            this.txtMaDichVu.BorderColor = System.Drawing.Color.Black;
            this.txtMaDichVu.BorderThickness = 2;
            this.txtMaDichVu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaDichVu.DefaultText = "";
            this.txtMaDichVu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaDichVu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaDichVu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaDichVu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaDichVu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaDichVu.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDichVu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaDichVu.Location = new System.Drawing.Point(13, 89);
            this.txtMaDichVu.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtMaDichVu.Name = "txtMaDichVu";
            this.txtMaDichVu.PlaceholderText = "";
            this.txtMaDichVu.SelectedText = "";
            this.txtMaDichVu.Size = new System.Drawing.Size(287, 36);
            this.txtMaDichVu.TabIndex = 0;
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Animated = true;
            this.btnTimkiem.BackColor = System.Drawing.Color.Transparent;
            this.btnTimkiem.BorderRadius = 15;
            this.btnTimkiem.BorderThickness = 2;
            this.btnTimkiem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTimkiem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTimkiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTimkiem.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTimkiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTimkiem.FillColor = System.Drawing.Color.White;
            this.btnTimkiem.FillColor2 = System.Drawing.Color.Black;
            this.btnTimkiem.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnTimkiem.ForeColor = System.Drawing.Color.White;
            this.btnTimkiem.Location = new System.Drawing.Point(538, 29);
            this.btnTimkiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(198, 54);
            this.btnTimkiem.TabIndex = 2;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseTransparentBackground = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // txtTKMT
            // 
            this.txtTKMT.Animated = true;
            this.txtTKMT.BackColor = System.Drawing.Color.Transparent;
            this.txtTKMT.BorderColor = System.Drawing.Color.Black;
            this.txtTKMT.BorderRadius = 10;
            this.txtTKMT.BorderThickness = 2;
            this.txtTKMT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTKMT.DefaultText = "";
            this.txtTKMT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTKMT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTKMT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTKMT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTKMT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTKMT.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtTKMT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTKMT.Location = new System.Drawing.Point(14, 29);
            this.txtTKMT.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtTKMT.Name = "txtTKMT";
            this.txtTKMT.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtTKMT.PlaceholderText = "Tìm kiếm theo Mã Dịch Vụ";
            this.txtTKMT.SelectedText = "";
            this.txtTKMT.Size = new System.Drawing.Size(500, 54);
            this.txtTKMT.TabIndex = 0;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.txtTKMT);
            this.guna2Panel1.Controls.Add(this.btnTimkiem);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1548, 107);
            this.guna2Panel1.TabIndex = 12;
            // 
            // pbAnhSP
            // 
            this.pbAnhSP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbAnhSP.ImageRotate = 0F;
            this.pbAnhSP.Location = new System.Drawing.Point(14, 504);
            this.pbAnhSP.Name = "pbAnhSP";
            this.pbAnhSP.Size = new System.Drawing.Size(286, 134);
            this.pbAnhSP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAnhSP.TabIndex = 4;
            this.pbAnhSP.TabStop = false;
            // 
            // btnChon
            // 
            this.btnChon.Animated = true;
            this.btnChon.BackColor = System.Drawing.Color.Transparent;
            this.btnChon.BorderRadius = 10;
            this.btnChon.BorderThickness = 2;
            this.btnChon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChon.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChon.FillColor = System.Drawing.Color.Blue;
            this.btnChon.FillColor2 = System.Drawing.Color.DeepSkyBlue;
            this.btnChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChon.ForeColor = System.Drawing.Color.White;
            this.btnChon.Location = new System.Drawing.Point(310, 504);
            this.btnChon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(96, 35);
            this.btnChon.TabIndex = 5;
            this.btnChon.Text = "Chọn";
            this.btnChon.UseTransparentBackground = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // FrmDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(1548, 885);
            this.Controls.Add(this.dgvQuanLyDichVu);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmDichVu";
            this.Text = "FrmDichVu";
            this.Load += new System.EventHandler(this.FrmDichVu_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyDichVu)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAnhSP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView dgvQuanLyDichVu;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayTao;
        private Guna.UI2.WinForms.Guna2GradientButton btnTimkiem;
        private Guna.UI2.WinForms.Guna2GradientButton btnSua;
        private Guna.UI2.WinForms.Guna2TextBox txtTKMT;
        private Guna.UI2.WinForms.Guna2GradientButton btnXoa;
        private Guna.UI2.WinForms.Guna2GradientButton btnLamMoi;
        private Guna.UI2.WinForms.Guna2GradientButton btnThem;
        private Guna.UI2.WinForms.Guna2ComboBox cboMaLoaiDichVu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtTenDichVu;
        private Guna.UI2.WinForms.Guna2TextBox txtMaDichVu;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtDonGia;
        private Guna.UI2.WinForms.Guna2PictureBox pbAnhSP;
        private Guna.UI2.WinForms.Guna2GradientButton btnChon;
    }
}