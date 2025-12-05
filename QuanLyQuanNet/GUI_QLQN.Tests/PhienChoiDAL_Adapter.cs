using DAL_QuanLyQuanNet;
using DTO_QuanLyQuanNet;
using System;
using System.Collections.Generic;

namespace GUI_QLQN.Tests
{
    public class PhienChoiDAL_Adapter : IPhienChoiDAL_Test
    {
        public List<PhienChoi_DTO> GetAll() => PhienChoi_DAL.GetAll();
        public bool ThemPhienChoi(PhienChoi_DTO phien) => PhienChoi_DAL.ThemPhienChoi(phien);
        public bool CapNhatPhienChoi(PhienChoi_DTO phien) => PhienChoi_DAL.CapNhatPhienChoi(phien);
        public bool XoaPhienChoi_Mem(string maPhien) => PhienChoi_DAL.XoaPhienChoi_Mem(maPhien);
        public List<PhienChoi_DTO> TimKiemPhien(string tuKhoa) => PhienChoi_DAL.TimKiemPhien(tuKhoa);
        public bool CapNhatKetThucPhien(string maPhien, DateTime thoiGianKetThuc, double tongSoGio, decimal tongTien, decimal soTienConLai)
            => PhienChoi_DAL.CapNhatKetThucPhien(maPhien, thoiGianKetThuc, tongSoGio, tongTien, soTienConLai);
        public decimal LayDonGiaHienTai() => PhienChoi_DAL.LayDonGiaHienTai();
        public string GenerateMaPhienMoi() => PhienChoi_DAL.GenerateMaPhienMoi();
    }
}