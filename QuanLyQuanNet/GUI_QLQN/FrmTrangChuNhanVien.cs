using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using QuanLyQuanNet.GUI;
using static GUI_QLQN.FrmDangNhap;

namespace GUI_QLQN
{
    public partial class FrmTrangChuNhanVien : Form
    {
        PrivateFontCollection privateFonts = new PrivateFontCollection();
        Timer hoverTimer = new Timer();
        bool isHovering = false;
        Dictionary<Guna2Button, Panel> hoverGroups = new Dictionary<Guna2Button, Panel>();

        public FrmTrangChuNhanVien()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            LoadOrbitronFont();
            RegisterHoverGroups();
        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            lblTitle2.Anchor = AnchorStyles.None;
            LoadThongTinNguoiDung();
        }

        private void RegisterHoverGroups()
        {
            hoverTimer.Interval = 300;
            hoverTimer.Tick += (s, e) =>
            {
                if (!isHovering)
                {
                    foreach (var panel in hoverGroups.Values)
                    {
                        if (panel.Visible)
                            panel.Visible = false;
                    }
                }
                hoverTimer.Stop();
            };

            // 👉 Đăng ký các nhóm tại đây
            hoverGroups.Add(btnQuanLyCaLamViec, panelQLCLV);
            hoverGroups.Add(btnQuanLyTaiKhoan, panelQLTK);
            hoverGroups.Add(btnQuanLyMayTinh, panelQLMT);
            hoverGroups.Add(btnQuanLyThanhToan, panelQLTT);
            hoverGroups.Add(btnQuanLyDichVu, panelQLDV);
            hoverGroups.Add(btnCaiDat, panelSetting);
            // Thêm các nhóm khác nếu cần

            foreach (var pair in hoverGroups)
            {
                var button = pair.Key;
                var panel = pair.Value;

                button.MouseEnter += (s, e) =>
                {
                    isHovering = true;
                    if (!panel.Visible) panel.Visible = true;
                    panel.BringToFront();
                };

                button.MouseLeave += (s, e) =>
                {
                    isHovering = false;
                    hoverTimer.Start();
                };

                panel.MouseEnter += (s, e) =>
                {
                    isHovering = true;
                    if (!panel.Visible) panel.Visible = true;
                    panel.BringToFront();
                };

                panel.MouseLeave += (s, e) =>
                {
                    isHovering = false;
                    hoverTimer.Start();
                };
            }
            foreach (var panel in hoverGroups.Values)
            {
                foreach (Control ctrl in panel.Controls)
                {
                    ctrl.MouseEnter += (s, e) =>
                    {
                        isHovering = true;
                        panel.Visible = true;
                        panel.BringToFront();
                    };

                    ctrl.MouseLeave += (s, e) =>
                    {
                        isHovering = false;
                        hoverTimer.Start();
                    };
                }
            }
        }

        private void LoadThongTinNguoiDung()
        {
            if (UserSession.NguoiDangNhap == null) return;
            string chucVu = UserSession.NguoiDangNhap.MaChucVu.ToUpper();
            string imagePath = (chucVu == "CV01") ? @"C:\\SD1903_DuAnTotNghiep\\Ảnh cho QLQN\\logo_admin" : @"Resources\\logo_nhân_viên";
            string fullPath = Path.Combine(Application.StartupPath, imagePath);
            if (File.Exists(fullPath))
            {
                AnhTaiKhoan.Image = Image.FromFile(fullPath);
            }
            lbTenNGSD.Text = UserSession.NguoiDangNhap.HoTen;
        }

        private void LoadOrbitronFont()
        {
            byte[] fontData = Properties.Resources.Orbitron_font;
            IntPtr fontPtr = Marshal.AllocCoTaskMem(fontData.Length);
            Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            privateFonts.AddMemoryFont(fontPtr, fontData.Length);
            Marshal.FreeCoTaskMem(fontPtr);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private Form activeForm = null;

        private void LoadChildForm(Form childForm, string title, Image icon = null)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelrac.Controls.Add(childForm);
            panelrac.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

            // Cập nhật tiêu đề và icon
            lblTitle2.Text = title.ToUpper();
            if (icon != null)
                pbICON.Image = icon;
        }
        private void CloseChildForm()
        {
            foreach (Control ctrl in panelrac.Controls.OfType<Form>().ToList())
            {
                ctrl.Dispose(); // hoặc Close()
                panelrac.Controls.Remove(ctrl);
            }
        }





        private void guna2Button3_Click(object sender, EventArgs e)
        {
            LoadChildForm(new FrmKhachHang(), "QUẢN LÝ KHÁCH HÀNG", Properties.Resources.icons8_user_100);
            lblTitle2.Left = (panelTitle.Width - lblTitle2.Width) / 2;
            lblTitle2.Top = (panelTitle.Height - lblTitle2.Height) / 2;
        }

        private void FrmQLMT_Click(object sender, EventArgs e)
        {
            LoadChildForm(new FrmQuanLyMT(), "QUẢN LÝ MÁY TÍNH", Properties.Resources.icons8_computer_64);
            lblTitle2.Left = (panelTitle.Width - lblTitle2.Width) / 2;
            lblTitle2.Top = (panelTitle.Height - lblTitle2.Height) / 2;
        }



        private void btnDV_Click(object sender, EventArgs e)
        {
            CloseChildForm(); // Đóng form con đang hiển thị
        }

        private void guna2Button3_Click_1(object sender, EventArgs e)
        {
            LoadChildForm(new FrmChiTietDatDV(), "ĐẶT HÀNG", Properties.Resources.icons8_purchase_order_100);
            lblTitle2.Left = (panelTitle.Width - lblTitle2.Width) / 2;
            lblTitle2.Top = (panelTitle.Height - lblTitle2.Height) / 2;
        }

        private void btnKM_Click(object sender, EventArgs e)
        {
            LoadChildForm(new FrmQuanLyThanhToan(), "THANH TOÁN", Properties.Resources.icons8_transaction_64);
            lblTitle2.Left = (panelTitle.Width - lblTitle2.Width) / 2;
            lblTitle2.Top = (panelTitle.Height - lblTitle2.Height) / 2;
        }

        private void btnTT_Click(object sender, EventArgs e)
        {
            CloseChildForm(); // Đóng form con đang hiển thị
        }


        private void btnPC_Click(object sender, EventArgs e)
        {
            LoadChildForm(new FrmPhienChoi(), "QUẢN LÝ PHIÊN CHƠI", Properties.Resources.icons8_controller_100);
            lblTitle2.Left = (panelTitle.Width - lblTitle2.Width) / 2;
            lblTitle2.Top = (panelTitle.Height - lblTitle2.Height) / 2;
        }

        private void btnQuanLyTaiKhoan_Click(object sender, EventArgs e)
        {
            CloseChildForm(); // Đóng form con đang hiển thị
        }

        private void btnThongBao_Click(object sender, EventArgs e)
        {
            LoadChildForm(new FrmQuanLyThongBao(), "QUẢN LÝ THÔNG BÁO", Properties.Resources.icons8_exclamation_mark_64);
            lblTitle2.Left = (panelTitle.Width - lblTitle2.Width) / 2;
            lblTitle2.Top = (panelTitle.Height - lblTitle2.Height) / 2;
        }

  

        private void btnQuanLyMayTinh_Click(object sender, EventArgs e)
        {
            CloseChildForm(); // Đóng form con đang hiển thị
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            LoadChildForm(new FrmQuanLyCLV(), "QUẢN LÝ CA LÀM VIỆC", Properties.Resources.icons8_working_100);
            lblTitle2.Left = (panelTitle.Width - lblTitle2.Width) / 2;
            lblTitle2.Top = (panelTitle.Height - lblTitle2.Height) / 2;
        }





        private void guna2Button5_Click(object sender, EventArgs e)
        {
            LoadChildForm(new FrmDichVu(), "QUẢN LÝ DỊCH VỤ", Properties.Resources.icons8_service);
            lblTitle2.Left = (panelTitle.Width - lblTitle2.Width) / 2;
            lblTitle2.Top = (panelTitle.Height - lblTitle2.Height) / 2;
        }



        private void btnQuanLyCaLamViec_Click(object sender, EventArgs e)
        {
            CloseChildForm(); // Đóng form con đang hiển thị
        }

        private void pbICON_Click(object sender, EventArgs e)
        {

            if (activeForm != null)
                activeForm.Close();
            activeForm = null;

            lblTitle2.Text = "QUÁN NET ZENSPACE";
            pbICON.Image = Properties.Resources._2; // hoặc logo_zenspace nếu đó là hình gốc
        }

        private void btnCaiDat_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                UserSession.NguoiDangNhap = null; // Xóa thông tin người dùng hiện tại
                this.Hide(); // Ẩn form hiện tại
                FrmDangNhap frmDangNhap = new FrmDangNhap(); // Mở lại form đăng nhập
                frmDangNhap.ShowDialog();
                this.Close(); // Đóng form Trang Chủ
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            FrmDMK frmDoiMatKhau = new FrmDMK();
            frmDoiMatKhau.ShowDialog();
        }
    }
}
