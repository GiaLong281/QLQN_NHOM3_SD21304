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
    public partial class FrmDMK : Form
    {
        public FrmDMK()
        {
            InitializeComponent();
        }

        private void btnDMK_Click(object sender, EventArgs e)
        {
            string maNV = txtMNV.Text.Trim();
            string tenNV = txtTNV.Text.Trim();
            string matKhauCu = txtMKC.Text.Trim();
            string matKhauMoi = txtMKM.Text.Trim();
            string xacNhanMK = txtXNMK.Text.Trim();

            // 1. Kiểm tra mã nhân viên có tồn tại không
            var nv = NhanVien_BUS.LayTheoMa(maNV);
            if (nv == null)
            {
                MessageBox.Show("Mã nhân viên không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 2. Kiểm tra tên nhân viên có khớp không
            if (!nv.HoTen.Trim().Equals(tenNV, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Tên nhân viên không khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 3. Kiểm tra mật khẩu cũ
            if (!NhanVien_BUS.KiemTraMatKhau(maNV, matKhauCu))
            {
                MessageBox.Show("Mật khẩu cũ không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 4. Kiểm tra mật khẩu mới
            if (string.IsNullOrEmpty(matKhauMoi))
            {
                MessageBox.Show("Mật khẩu mới không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (matKhauMoi == matKhauCu)
            {
                MessageBox.Show("Mật khẩu mới phải khác mật khẩu cũ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (matKhauMoi != xacNhanMK)
            {
                MessageBox.Show("Xác nhận mật khẩu không khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 5. Gọi BUS để đổi mật khẩu
            bool doiThanhCong = NhanVien_BUS.DoiMatKhau(maNV, matKhauMoi);

            if (doiThanhCong)
            {
                MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMKC.Clear();
                txtMKM.Clear();
                txtXNMK.Clear();
            }
            else
            {
                MessageBox.Show("Đổi mật khẩu thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
