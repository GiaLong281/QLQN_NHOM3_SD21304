namespace GUI_QLQN
{
    partial class FrmDangNhap
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
            this.components = new System.ComponentModel.Container();
            this.txtTenDN = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMK = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.btnExit = new Guna.UI2.WinForms.Guna2ImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTenDN
            // 
            this.txtTenDN.Animated = true;
            this.txtTenDN.BorderColor = System.Drawing.Color.Gray;
            this.txtTenDN.BorderRadius = 5;
            this.txtTenDN.BorderThickness = 2;
            this.txtTenDN.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtTenDN.DefaultText = "";
            this.txtTenDN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenDN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenDN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenDN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenDN.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtTenDN.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.txtTenDN.FocusedState.FillColor = System.Drawing.Color.White;
            this.txtTenDN.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.txtTenDN.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtTenDN.ForeColor = System.Drawing.Color.Black;
            this.txtTenDN.HoverState.BorderColor = System.Drawing.Color.Black;
            this.txtTenDN.IconLeft = global::GUI_QLQN.Properties.Resources.logo_admin;
            this.txtTenDN.IconLeftSize = new System.Drawing.Size(40, 40);
            this.txtTenDN.Location = new System.Drawing.Point(1088, 255);
            this.txtTenDN.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtTenDN.PlaceholderText = "Mã Nhân Viên";
            this.txtTenDN.SelectedText = "";
            this.txtTenDN.Size = new System.Drawing.Size(356, 55);
            this.txtTenDN.TabIndex = 1;
            this.txtTenDN.UseWaitCursor = true;
            // 
            // txtMK
            // 
            this.txtMK.Animated = true;
            this.txtMK.BorderColor = System.Drawing.Color.Gray;
            this.txtMK.BorderRadius = 5;
            this.txtMK.BorderThickness = 2;
            this.txtMK.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtMK.DefaultText = "";
            this.txtMK.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMK.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMK.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtMK.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.txtMK.FocusedState.FillColor = System.Drawing.Color.White;
            this.txtMK.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.txtMK.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtMK.ForeColor = System.Drawing.Color.Black;
            this.txtMK.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMK.IconLeft = global::GUI_QLQN.Properties.Resources.icons8_lock_50;
            this.txtMK.IconLeftSize = new System.Drawing.Size(40, 40);
            this.txtMK.Location = new System.Drawing.Point(1088, 360);
            this.txtMK.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtMK.Name = "txtMK";
            this.txtMK.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtMK.PlaceholderText = "Mật khẩu";
            this.txtMK.SelectedText = "";
            this.txtMK.Size = new System.Drawing.Size(356, 55);
            this.txtMK.TabIndex = 2;
            this.txtMK.UseWaitCursor = true;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.Image = global::GUI_QLQN.Properties.Resources._2;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(1190, 38);
            this.guna2PictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(152, 152);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 3;
            this.guna2PictureBox2.TabStop = false;
            this.guna2PictureBox2.UseTransparentBackground = true;
            this.guna2PictureBox2.UseWaitCursor = true;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.guna2PictureBox1;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2PictureBox1.Image = global::GUI_QLQN.Properties.Resources.Banner_Quán_Net_Zenpacia;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(1020, 745);
            this.guna2PictureBox1.TabIndex = 5;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseWaitCursor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Animated = true;
            this.btnLogin.BorderColor = System.Drawing.Color.Gray;
            this.btnLogin.BorderRadius = 20;
            this.btnLogin.BorderThickness = 2;
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.FillColor = System.Drawing.Color.DarkGray;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btnLogin.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnLogin.HoverState.Image = global::GUI_QLQN.Properties.Resources.icons8_right_50;
            this.btnLogin.Image = global::GUI_QLQN.Properties.Resources.right_black;
            this.btnLogin.ImageSize = new System.Drawing.Size(50, 50);
            this.btnLogin.Location = new System.Drawing.Point(1223, 528);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(94, 86);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.UseWaitCursor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnExit.HoverState.Image = global::GUI_QLQN.Properties.Resources.exit;
            this.btnExit.HoverState.ImageSize = new System.Drawing.Size(50, 50);
            this.btnExit.Image = global::GUI_QLQN.Properties.Resources.exit1;
            this.btnExit.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnExit.ImageRotate = 0F;
            this.btnExit.ImageSize = new System.Drawing.Size(50, 50);
            this.btnExit.Location = new System.Drawing.Point(1431, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.PressedState.Image = global::GUI_QLQN.Properties.Resources.exit;
            this.btnExit.PressedState.ImageSize = new System.Drawing.Size(50, 50);
            this.btnExit.Size = new System.Drawing.Size(77, 57);
            this.btnExit.TabIndex = 6;
            this.btnExit.UseTransparentBackground = true;
            this.btnExit.UseWaitCursor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FrmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1507, 745);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.guna2PictureBox2);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.txtTenDN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDangNhap";
            this.Text = "FrmDangNhap";
            this.UseWaitCursor = true;
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox txtTenDN;
        private Guna.UI2.WinForms.Guna2TextBox txtMK;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2ImageButton btnExit;
    }
}