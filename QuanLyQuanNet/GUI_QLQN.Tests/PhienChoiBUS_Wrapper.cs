using DTO_QuanLyQuanNet;
using System;
using System.Collections.Generic;

namespace GUI_QLQN.Tests
{
    public class PhienChoiBUS_Wrapper
    {
        private readonly IPhienChoiDAL_Test _phienChoiDAL;

        public PhienChoiBUS_Wrapper(IPhienChoiDAL_Test phienChoiDAL = null)
        {
            _phienChoiDAL = phienChoiDAL ?? new PhienChoiDAL_Adapter();
        }

        public List<PhienChoi_DTO> LayTatCaPhien() => _phienChoiDAL.GetAll();
        public bool ThemPhien(PhienChoi_DTO pc) => _phienChoiDAL.ThemPhienChoi(pc);
        public bool CapNhatPhien(PhienChoi_DTO pc) => _phienChoiDAL.CapNhatPhienChoi(pc);
        public bool XoaPhien(string maPhien) => _phienChoiDAL.XoaPhienChoi_Mem(maPhien);
        public List<PhienChoi_DTO> TimKiemPhien(string tuKhoa) => _phienChoiDAL.TimKiemPhien(tuKhoa);
        public bool CapNhatKetThucPhien(string maPhien, DateTime tgKetThuc, double tongGio, decimal tongTien, decimal tienConLai)
            => _phienChoiDAL.CapNhatKetThucPhien(maPhien, tgKetThuc, tongGio, tongTien, tienConLai);
        public decimal LayDonGia() => _phienChoiDAL.LayDonGiaHienTai();
        public string TaoMaPhienMoi() => _phienChoiDAL.GenerateMaPhienMoi();
    }
}