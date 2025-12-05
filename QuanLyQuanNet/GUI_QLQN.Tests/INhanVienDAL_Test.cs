using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLyQuanNet;

namespace GUI_QLQN.Tests
{
    public interface INhanVienDAL_Test
    {
        NhanVien_DTO KiemTraDangNhap(string maNV, string matKhau);
        bool KiemTraMatKhau(string maNV, string matKhau);
        bool DoiMatKhau(string maNV, string matKhauMoi);
    }
}
