using System;
using System.Data;
using System.Collections.Generic;
using DTO_QuanLyQuanNet;

namespace GUI_QLQN.Tests
{
    public interface IThanhToanDAL_Test
    {
        List<ThanhToan_DTO> LayTatCa();
        DataTable LayLichSuThanhToan();
        ThanhToan_DTO LayTheoMa(string ma);
        List<ThanhToan_DTO> TimKiemTheoMa(string ma);

        (bool Success, string Message, decimal SoGio, decimal TienGio, decimal TienDV, decimal GiamGia, decimal TongPhaiTra)
        ThanhToanCoKhuyenMai(string maPhien, decimal donGiaGio);

        (bool Success, string Message, decimal SoGio, decimal TienGio, decimal TienDV, decimal GiamGia, decimal TongCanThu)
        TinhTienXuatHoaDon(string maPhien, decimal donGiaGio);

        (bool Success, string Message, decimal SoGio, decimal TienGio, decimal TienDV, decimal GiamGia, decimal TongPhaiTra)
        TinhTienDuKien(DateTime thoiGianBatDau, DateTime thoiGianKetThuc, decimal donGiaGio, decimal tienDV = 0, decimal giamGia = 0);
    }
}