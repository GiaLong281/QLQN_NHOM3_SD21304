using System;
using System.Data;
using System.Collections.Generic;
using DAL_QuanLyQuanNet;
using DTO_QuanLyQuanNet;

namespace GUI_QLQN.Tests
{
    public class ThanhToanDAL_Adapter : IThanhToanDAL_Test
    {
        public List<ThanhToan_DTO> LayTatCa()
            => ThanhToan_DAL.LayTatCa();

        public DataTable LayLichSuThanhToan()
            => ThanhToan_DAL.LayLichSuThanhToan();

        public ThanhToan_DTO LayTheoMa(string ma)
            => ThanhToan_DAL.LayTheoMa(ma);

        public List<ThanhToan_DTO> TimKiemTheoMa(string ma)
            => ThanhToan_DAL.TimKiemTheoMa(ma);

        public (bool Success, string Message, decimal SoGio, decimal TienGio, decimal TienDV, decimal GiamGia, decimal TongPhaiTra)
        ThanhToanCoKhuyenMai(string maPhien, decimal donGiaGio)
            => ThanhToan_DAL.ThanhToanCoKhuyenMai(maPhien, donGiaGio);

        public (bool Success, string Message, decimal SoGio, decimal TienGio, decimal TienDV, decimal GiamGia, decimal TongCanThu)
        TinhTienXuatHoaDon(string maPhien, decimal donGiaGio)
            => ThanhToan_DAL.TinhTienXuatHoaDon(maPhien, donGiaGio);

        public (bool Success, string Message, decimal SoGio, decimal TienGio, decimal TienDV, decimal GiamGia, decimal TongPhaiTra)
        TinhTienDuKien(DateTime thoiGianBatDau, DateTime thoiGianKetThuc, decimal donGiaGio, decimal tienDV = 0, decimal giamGia = 0)
            => ThanhToan_DAL.TinhTienDuKien(thoiGianBatDau, thoiGianKetThuc, donGiaGio, tienDV, giamGia);
    }
}