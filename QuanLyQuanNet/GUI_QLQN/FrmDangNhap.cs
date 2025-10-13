using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLQN
{
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string maNV = txtTenDN.Text.Trim();
            string password = txtMK.Text.Trim();

            var nv = NhanVien_BUS.DangNhap(maNV, password);
            if (nv != null)
            {
                UserSession.NguoiDangNhap = nv;

                // Phân quyền dựa theo mã chức vụ
                if (nv.MaChucVu.ToUpper() == "CV01") // Admin
                {
                    new FrmTrangChu().Show();     // form chính quyền admin
                }
                else
                {
                    new FrmTrangChuNhanVien().Show(); // form riêng cho nhân viên
                }

                this.Hide();
            }
            else
            {
                MessageBox.Show("Mã nhân viên hoặc mật khẩu không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static class UserSession
        {
            public static NhanVien_DTO NguoiDangNhap { get; set; }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
