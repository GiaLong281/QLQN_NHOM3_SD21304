namespace GUI_QLQN
{
    partial class ucDichVu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTenDichVu = new System.Windows.Forms.Label();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.txtSoLuong = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnGiam = new Guna.UI2.WinForms.Guna2Button();
            this.btnTang = new Guna.UI2.WinForms.Guna2Button();
            this.paneluc = new System.Windows.Forms.Panel();
            this.pbAnhSP = new Guna.UI2.WinForms.Guna2PictureBox();
            this.paneluc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnhSP)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTenDichVu
            // 
            this.lblTenDichVu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTenDichVu.AutoSize = true;
            this.lblTenDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDichVu.Location = new System.Drawing.Point(99, 160);
            this.lblTenDichVu.Name = "lblTenDichVu";
            this.lblTenDichVu.Size = new System.Drawing.Size(57, 20);
            this.lblTenDichVu.TabIndex = 0;
            this.lblTenDichVu.Text = "label1";
            this.lblTenDichVu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDonGia
            // 
            this.lblDonGia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Location = new System.Drawing.Point(72, 188);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(109, 20);
            this.lblDonGia.TabIndex = 1;
            this.lblDonGia.Text = " Giá : xxx VNĐ";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoLuong.DefaultText = "";
            this.txtSoLuong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoLuong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoLuong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoLuong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoLuong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoLuong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSoLuong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoLuong.Location = new System.Drawing.Point(107, 223);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.PlaceholderText = "";
            this.txtSoLuong.ReadOnly = true;
            this.txtSoLuong.SelectedText = "";
            this.txtSoLuong.Size = new System.Drawing.Size(37, 27);
            this.txtSoLuong.TabIndex = 2;
            this.txtSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnGiam
            // 
            this.btnGiam.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGiam.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGiam.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGiam.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGiam.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGiam.FillColor = System.Drawing.Color.Maroon;
            this.btnGiam.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGiam.ForeColor = System.Drawing.Color.White;
            this.btnGiam.Location = new System.Drawing.Point(48, 223);
            this.btnGiam.Name = "btnGiam";
            this.btnGiam.Size = new System.Drawing.Size(36, 27);
            this.btnGiam.TabIndex = 3;
            this.btnGiam.Text = "-";
            this.btnGiam.Click += new System.EventHandler(this.BtnGiam_Click);
            // 
            // btnTang
            // 
            this.btnTang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTang.FillColor = System.Drawing.Color.Green;
            this.btnTang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTang.ForeColor = System.Drawing.Color.White;
            this.btnTang.Location = new System.Drawing.Point(166, 223);
            this.btnTang.Name = "btnTang";
            this.btnTang.Size = new System.Drawing.Size(39, 27);
            this.btnTang.TabIndex = 4;
            this.btnTang.Text = "+";
            this.btnTang.Click += new System.EventHandler(this.BtnTang_Click);
            // 
            // paneluc
            // 
            this.paneluc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.paneluc.Controls.Add(this.pbAnhSP);
            this.paneluc.Controls.Add(this.btnTang);
            this.paneluc.Controls.Add(this.lblDonGia);
            this.paneluc.Controls.Add(this.btnGiam);
            this.paneluc.Controls.Add(this.lblTenDichVu);
            this.paneluc.Controls.Add(this.txtSoLuong);
            this.paneluc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneluc.Location = new System.Drawing.Point(0, 0);
            this.paneluc.Name = "paneluc";
            this.paneluc.Size = new System.Drawing.Size(250, 270);
            this.paneluc.TabIndex = 5;
            // 
            // pbAnhSP
            // 
            this.pbAnhSP.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbAnhSP.ImageRotate = 0F;
            this.pbAnhSP.Location = new System.Drawing.Point(0, 0);
            this.pbAnhSP.Name = "pbAnhSP";
            this.pbAnhSP.Size = new System.Drawing.Size(246, 157);
            this.pbAnhSP.TabIndex = 5;
            this.pbAnhSP.TabStop = false;
            // 
            // ucDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.paneluc);
            this.Name = "ucDichVu";
            this.Size = new System.Drawing.Size(250, 270);
            this.Load += new System.EventHandler(this.ucDichVu_Load);
            this.paneluc.ResumeLayout(false);
            this.paneluc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnhSP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTenDichVu;
        private System.Windows.Forms.Label lblDonGia;
        private Guna.UI2.WinForms.Guna2TextBox txtSoLuong;
        private Guna.UI2.WinForms.Guna2Button btnGiam;
        private Guna.UI2.WinForms.Guna2Button btnTang;
        private System.Windows.Forms.Panel paneluc;
        private Guna.UI2.WinForms.Guna2PictureBox pbAnhSP;
    }
}
