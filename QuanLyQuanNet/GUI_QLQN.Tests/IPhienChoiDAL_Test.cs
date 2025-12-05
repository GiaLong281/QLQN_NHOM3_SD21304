using DTO_QuanLyQuanNet;
using System.Collections.Generic;

namespace GUI_QLQN.Tests
{
    public interface IPhienChoiDAL_Test
    {
        List<PhienChoi_DTO> GetAll();
        bool ThemPhienChoi(PhienChoi_DTO phien);
        bool CapNhatPhienChoi(PhienChoi_DTO phien);
        bool XoaPhienChoi_Mem(string maPhien);
        List<PhienChoi_DTO> TimKiemPhien(string tuKhoa);
        bool CapNhatKetThucPhien(string maPhien, DateTime thoiGianKetThuc, double tongSoGio, decimal tongTien, decimal soTienConLai);
        decimal LayDonGiaHienTai();
        string GenerateMaPhienMoi();
    }
}