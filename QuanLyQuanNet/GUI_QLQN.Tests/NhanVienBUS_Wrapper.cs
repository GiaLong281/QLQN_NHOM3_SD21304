using BLL_QuanLyQuanNet;
using DTO_QuanLyQuanNet;

namespace GUI_QLQN.Tests
{
    // Wrapper class - dùng cho testing
    public class NhanVienBUS_Wrapper
    {
        private readonly INhanVienDAL_Test _nhanVienDAL;

        public NhanVienBUS_Wrapper(INhanVienDAL_Test nhanVienDAL = null)
        {
            _nhanVienDAL = nhanVienDAL ?? new NhanVienDAL_Adapter();
        }

        // Methods cho testing
        public NhanVien_DTO DangNhap(string maNV, string matKhau)
        {
            return _nhanVienDAL.KiemTraDangNhap(maNV, matKhau);
        }

        public bool DoiMatKhau(string maNV, string matKhauMoi)
        {
            return _nhanVienDAL.DoiMatKhau(maNV, matKhauMoi);
        }

        public bool KiemTraMatKhau(string maNV, string matKhau)
        {
            return _nhanVienDAL.KiemTraMatKhau(maNV, matKhau);
        }
    }
}