using Guna.UI2.WinForms;
using System.Windows.Forms;

namespace QuanLyQuanNet.GUI
{
    partial class FrmKhachHang
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvKhachHang = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtSoDu = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNgayTao = new Guna.UI2.WinForms.Guna2TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cboLoaiKH = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cboTrangThai = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnDelete = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnAdd = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnEdit = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtCCCD = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSDT = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtHoTen = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMK = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenDN = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMaKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label = new Guna.UI2.WinForms.Guna2Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.label.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSearch.Animated = true;
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BorderRadius = 5;
            this.btnSearch.BorderThickness = 2;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(785, 40);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(108, 36);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.UseTransparentBackground = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtSearch.Animated = true;
            this.txtSearch.BorderColor = System.Drawing.Color.Black;
            this.txtSearch.BorderThickness = 2;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(292, 40);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtSearch.PlaceholderText = "Tìm kiếm theo tên đăng nhập...";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(464, 36);
            this.txtSearch.TabIndex = 8;
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.AllowUserToAddRows = false;
            this.dgvKhachHang.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvKhachHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKhachHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKhachHang.ColumnHeadersHeight = 50;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKhachHang.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKhachHang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvKhachHang.Location = new System.Drawing.Point(0, 109);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.ReadOnly = true;
            this.dgvKhachHang.RowHeadersVisible = false;
            this.dgvKhachHang.RowHeadersWidth = 62;
            this.dgvKhachHang.RowTemplate.Height = 50;
            this.dgvKhachHang.Size = new System.Drawing.Size(1024, 776);
            this.dgvKhachHang.TabIndex = 7;
            this.dgvKhachHang.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvKhachHang.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvKhachHang.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvKhachHang.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvKhachHang.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvKhachHang.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvKhachHang.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvKhachHang.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgvKhachHang.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvKhachHang.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.dgvKhachHang.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvKhachHang.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvKhachHang.ThemeStyle.HeaderStyle.Height = 50;
            this.dgvKhachHang.ThemeStyle.ReadOnly = true;
            this.dgvKhachHang.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvKhachHang.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvKhachHang.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.dgvKhachHang.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvKhachHang.ThemeStyle.RowsStyle.Height = 50;
            this.dgvKhachHang.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.LightBlue;
            this.dgvKhachHang.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellClick);
            // 
            // txtSoDu
            // 
            this.txtSoDu.Animated = true;
            this.txtSoDu.BorderColor = System.Drawing.Color.Black;
            this.txtSoDu.BorderThickness = 2;
            this.txtSoDu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoDu.DefaultText = "";
            this.txtSoDu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoDu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoDu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoDu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoDu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoDu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoDu.Location = new System.Drawing.Point(16, 564);
            this.txtSoDu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoDu.Name = "txtSoDu";
            this.txtSoDu.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtSoDu.PlaceholderText = "";
            this.txtSoDu.SelectedText = "";
            this.txtSoDu.Size = new System.Drawing.Size(232, 35);
            this.txtSoDu.TabIndex = 47;
            // 
            // txtNgayTao
            // 
            this.txtNgayTao.Animated = true;
            this.txtNgayTao.BorderColor = System.Drawing.Color.Black;
            this.txtNgayTao.BorderThickness = 2;
            this.txtNgayTao.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNgayTao.DefaultText = "";
            this.txtNgayTao.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNgayTao.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNgayTao.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNgayTao.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNgayTao.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNgayTao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayTao.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNgayTao.Location = new System.Drawing.Point(280, 208);
            this.txtNgayTao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNgayTao.Name = "txtNgayTao";
            this.txtNgayTao.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtNgayTao.PlaceholderText = "";
            this.txtNgayTao.SelectedText = "";
            this.txtNgayTao.Size = new System.Drawing.Size(232, 35);
            this.txtNgayTao.TabIndex = 46;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(12, 540);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 20);
            this.label12.TabIndex = 45;
            this.label12.Text = "Số dư :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(276, 184);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 20);
            this.label13.TabIndex = 44;
            this.label13.Text = "Ngày tạo :";
            // 
            // cboLoaiKH
            // 
            this.cboLoaiKH.BackColor = System.Drawing.Color.Transparent;
            this.cboLoaiKH.BorderColor = System.Drawing.Color.Black;
            this.cboLoaiKH.BorderThickness = 2;
            this.cboLoaiKH.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboLoaiKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiKH.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboLoaiKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboLoaiKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLoaiKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboLoaiKH.ItemHeight = 30;
            this.cboLoaiKH.Location = new System.Drawing.Point(279, 138);
            this.cboLoaiKH.Name = "cboLoaiKH";
            this.cboLoaiKH.Size = new System.Drawing.Size(232, 36);
            this.cboLoaiKH.TabIndex = 42;
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.BackColor = System.Drawing.Color.Transparent;
            this.cboTrangThai.BorderColor = System.Drawing.Color.Black;
            this.cboTrangThai.BorderThickness = 2;
            this.cboTrangThai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboTrangThai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTrangThai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboTrangThai.ItemHeight = 30;
            this.cboTrangThai.Location = new System.Drawing.Point(278, 69);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(232, 36);
            this.cboTrangThai.TabIndex = 41;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDelete.Animated = true;
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BorderRadius = 10;
            this.btnDelete.BorderThickness = 2;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.Brown;
            this.btnDelete.FillColor2 = System.Drawing.Color.DeepPink;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(271, 730);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(109, 43);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseTransparentBackground = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAdd.Animated = true;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BorderRadius = 10;
            this.btnAdd.BorderThickness = 2;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.Blue;
            this.btnAdd.FillColor2 = System.Drawing.Color.DeepSkyBlue;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(12, 730);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(109, 43);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseTransparentBackground = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEdit.Animated = true;
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.BorderRadius = 10;
            this.btnEdit.BorderThickness = 2;
            this.btnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEdit.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEdit.FillColor = System.Drawing.Color.DarkKhaki;
            this.btnEdit.FillColor2 = System.Drawing.Color.GreenYellow;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(141, 730);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(109, 43);
            this.btnEdit.TabIndex = 24;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseTransparentBackground = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRefresh.Animated = true;
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.BorderRadius = 10;
            this.btnRefresh.BorderThickness = 2;
            this.btnRefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefresh.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRefresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRefresh.FillColor2 = System.Drawing.Color.GreenYellow;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(402, 730);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(109, 43);
            this.btnRefresh.TabIndex = 16;
            this.btnRefresh.Text = "Làm Mới";
            this.btnRefresh.UseTransparentBackground = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // txtCCCD
            // 
            this.txtCCCD.Animated = true;
            this.txtCCCD.BorderColor = System.Drawing.Color.Black;
            this.txtCCCD.BorderThickness = 2;
            this.txtCCCD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCCCD.DefaultText = "";
            this.txtCCCD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCCCD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCCCD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCCCD.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCCCD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCCCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCCCD.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCCCD.Location = new System.Drawing.Point(16, 492);
            this.txtCCCD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtCCCD.PlaceholderText = "";
            this.txtCCCD.SelectedText = "";
            this.txtCCCD.Size = new System.Drawing.Size(232, 35);
            this.txtCCCD.TabIndex = 39;
            // 
            // txtEmail
            // 
            this.txtEmail.Animated = true;
            this.txtEmail.BorderColor = System.Drawing.Color.Black;
            this.txtEmail.BorderThickness = 2;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Location = new System.Drawing.Point(16, 420);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtEmail.PlaceholderText = "";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(232, 35);
            this.txtEmail.TabIndex = 37;
            // 
            // txtSDT
            // 
            this.txtSDT.Animated = true;
            this.txtSDT.BorderColor = System.Drawing.Color.Black;
            this.txtSDT.BorderThickness = 2;
            this.txtSDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSDT.DefaultText = "";
            this.txtSDT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSDT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSDT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSDT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSDT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSDT.Location = new System.Drawing.Point(16, 348);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtSDT.PlaceholderText = "";
            this.txtSDT.SelectedText = "";
            this.txtSDT.Size = new System.Drawing.Size(232, 35);
            this.txtSDT.TabIndex = 38;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Animated = true;
            this.txtHoTen.BorderColor = System.Drawing.Color.Black;
            this.txtHoTen.BorderThickness = 2;
            this.txtHoTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHoTen.DefaultText = "";
            this.txtHoTen.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHoTen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHoTen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHoTen.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHoTen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHoTen.Location = new System.Drawing.Point(16, 274);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtHoTen.PlaceholderText = "";
            this.txtHoTen.SelectedText = "";
            this.txtHoTen.Size = new System.Drawing.Size(232, 35);
            this.txtHoTen.TabIndex = 35;
            // 
            // txtMK
            // 
            this.txtMK.Animated = true;
            this.txtMK.BorderColor = System.Drawing.Color.Black;
            this.txtMK.BorderThickness = 2;
            this.txtMK.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMK.DefaultText = "";
            this.txtMK.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMK.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMK.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMK.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMK.Location = new System.Drawing.Point(16, 208);
            this.txtMK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMK.Name = "txtMK";
            this.txtMK.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtMK.PlaceholderText = "";
            this.txtMK.SelectedText = "";
            this.txtMK.Size = new System.Drawing.Size(232, 35);
            this.txtMK.TabIndex = 36;
            this.txtMK.UseSystemPasswordChar = true;
            // 
            // txtTenDN
            // 
            this.txtTenDN.Animated = true;
            this.txtTenDN.BorderColor = System.Drawing.Color.Black;
            this.txtTenDN.BorderThickness = 2;
            this.txtTenDN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenDN.DefaultText = "";
            this.txtTenDN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenDN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenDN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenDN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenDN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDN.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenDN.Location = new System.Drawing.Point(16, 139);
            this.txtTenDN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtTenDN.PlaceholderText = "";
            this.txtTenDN.SelectedText = "";
            this.txtTenDN.Size = new System.Drawing.Size(232, 35);
            this.txtTenDN.TabIndex = 33;
            // 
            // txtMaKH
            // 
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
            this.txtMaKH.Location = new System.Drawing.Point(16, 70);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtMaKH.PlaceholderText = "";
            this.txtMaKH.SelectedText = "";
            this.txtMaKH.Size = new System.Drawing.Size(232, 35);
            this.txtMaKH.TabIndex = 34;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(275, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 20);
            this.label10.TabIndex = 32;
            this.label10.Text = "Loại Khách Hàng :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(274, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 20);
            this.label8.TabIndex = 30;
            this.label8.Text = "Trạng Thái :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(12, 468);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 20);
            this.label9.TabIndex = 31;
            this.label9.Text = "CCCD :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(8, 396);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Email :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(8, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "SĐT :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Họ Tên :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(12, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Mật khẩu :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tên Đăng Nhập :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Mã Khách Hàng :";
            // 
            // label
            // 
            this.label.BackColor = System.Drawing.Color.White;
            this.label.Controls.Add(this.label11);
            this.label.Controls.Add(this.btnSearch);
            this.label.Controls.Add(this.txtSearch);
            this.label.Dock = System.Windows.Forms.DockStyle.Top;
            this.label.Location = new System.Drawing.Point(0, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(1548, 109);
            this.label.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(28, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(212, 45);
            this.label11.TabIndex = 10;
            this.label11.Text = "DANH SÁCH";
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderThickness = 2;
            this.guna2GroupBox1.Controls.Add(this.btnDelete);
            this.guna2GroupBox1.Controls.Add(this.txtMaKH);
            this.guna2GroupBox1.Controls.Add(this.btnEdit);
            this.guna2GroupBox1.Controls.Add(this.txtSoDu);
            this.guna2GroupBox1.Controls.Add(this.btnAdd);
            this.guna2GroupBox1.Controls.Add(this.label3);
            this.guna2GroupBox1.Controls.Add(this.label2);
            this.guna2GroupBox1.Controls.Add(this.txtNgayTao);
            this.guna2GroupBox1.Controls.Add(this.btnRefresh);
            this.guna2GroupBox1.Controls.Add(this.label5);
            this.guna2GroupBox1.Controls.Add(this.label1);
            this.guna2GroupBox1.Controls.Add(this.label12);
            this.guna2GroupBox1.Controls.Add(this.label7);
            this.guna2GroupBox1.Controls.Add(this.label6);
            this.guna2GroupBox1.Controls.Add(this.label13);
            this.guna2GroupBox1.Controls.Add(this.label9);
            this.guna2GroupBox1.Controls.Add(this.cboLoaiKH);
            this.guna2GroupBox1.Controls.Add(this.label8);
            this.guna2GroupBox1.Controls.Add(this.cboTrangThai);
            this.guna2GroupBox1.Controls.Add(this.label10);
            this.guna2GroupBox1.Controls.Add(this.txtCCCD);
            this.guna2GroupBox1.Controls.Add(this.txtTenDN);
            this.guna2GroupBox1.Controls.Add(this.txtEmail);
            this.guna2GroupBox1.Controls.Add(this.txtMK);
            this.guna2GroupBox1.Controls.Add(this.txtSDT);
            this.guna2GroupBox1.Controls.Add(this.txtHoTen);
            this.guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(1024, 109);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(524, 776);
            this.guna2GroupBox1.TabIndex = 14;
            this.guna2GroupBox1.Text = "Thông Tin";
            // 
            // FrmKhachHang
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(1548, 885);
            this.Controls.Add(this.dgvKhachHang);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmKhachHang";
            this.Text = "Quản lý Khách Hàng";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.label.ResumeLayout(false);
            this.label.PerformLayout();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }
        private Guna2DataGridView dgvKhachHang;
        private Guna2Button btnSearch;
        private Guna2TextBox txtSearch;
        private Guna2GradientButton btnRefresh;
        private Guna2GradientButton btnDelete;
        private Guna2GradientButton btnEdit;
        private Guna2GradientButton btnAdd;
        private Label label2;
        private Label label3;
        private Label label6;
        private Label label7;
        private Label label1;
        private Label label5;
        private Label label10;
        private Label label8;
        private Label label9;
        private Guna2TextBox txtEmail;
        private Guna2TextBox txtSDT;
        private Guna2TextBox txtHoTen;
        private Guna2TextBox txtMK;
        private Guna2TextBox txtTenDN;
        private Guna2TextBox txtMaKH;
        private Guna2TextBox txtCCCD;
        private Guna2ComboBox cboTrangThai;
        private Guna2ComboBox cboLoaiKH;
        private Guna2TextBox txtSoDu;
        private Guna2TextBox txtNgayTao;
        private Label label12;
        private Label label13;
        private Guna2Panel label;
        private Label label11;
        private Guna2GroupBox guna2GroupBox1;
    }
}
