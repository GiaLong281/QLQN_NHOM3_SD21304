using DAL_QuanLyQuanNet;
using DTO_QuanLyQuanNet;

namespace GUI_QLQN.Tests
{
    // Adapter class - gọi đến static methods gốc
    public class NhanVienDAL_Adapter : INhanVienDAL_Test
    {
        public NhanVien_DTO KiemTraDangNhap(string maNV, string matKhau)
        {
            // Gọi method static gốc - KHÔNG sửa code gốc
            return NhanVien_DAL.KiemTraDangNhap(maNV, matKhau);
        }

        public bool KiemTraMatKhau(string maNV, string matKhau)
        {
            return NhanVien_DAL.KiemTraMatKhau(maNV, matKhau);
        }

        public bool DoiMatKhau(string maNV, string matKhauMoi)
        {
            return NhanVien_DAL.DoiMatKhau(maNV, matKhauMoi);
        }
    }
}