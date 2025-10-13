using System;
using System.Collections.Generic;
using System.Data;
using DAL_QuanLyQuanNet;
using DTO_QuanLyQuanNet;

namespace BUS_QuanLyQuanNet
{
 

    public class ThanhToan_BUS
    {
        public static List<ThanhToan_DTO> LayTatCa()
        {
            return ThanhToan_DAL.LayTatCa();
        }

        public static DataTable LayLichSuThanhToan()
        {
            return ThanhToan_DAL.LayLichSuThanhToan();
        }


        public static ThanhToan_DTO LayTheoMa(string ma)
        {
            return ThanhToan_DAL.LayTheoMa(ma);
        }

        // Tìm kiếm thanh toán theo mã hoặc mã khách hàng
        public static List<ThanhToan_DTO> TimKiem(string ma)
        {
            return ThanhToan_DAL.TimKiemTheoMa(ma);
        }

        // Thanh toán cho khách có tài khoản (có khuyến mãi, trừ tiền)
        public (bool Success, string Message, decimal SoGio, decimal TienGio, decimal TienDV, decimal GiamGia, decimal TongPhaiTra)
        ThanhToanCoKhuyenMai(string maPhien, decimal donGiaGio)
            => ThanhToan_DAL.ThanhToanCoKhuyenMai(maPhien, donGiaGio);

        // Tính tiền cho khách vãng lai (không trừ tài khoản)
        public (bool Success, string Message, decimal SoGio, decimal TienGio, decimal TienDV, decimal GiamGia, decimal TongCanThu)
        TinhTienXuatHoaDon(string maPhien, decimal donGiaGio)
            => ThanhToan_DAL.TinhTienXuatHoaDon(maPhien, donGiaGio);

        //gọi hàm tính tổng tiền thanh toán

        public static (bool Success, string Message, decimal SoGio, decimal TienGio, decimal TienDV, decimal GiamGia, decimal TongPhaiTra)
        TinhTienDuKien(DateTime thoiGianBatDau, DateTime thoiGianKetThuc, decimal donGiaGio, decimal tienDV = 0, decimal giamGia = 0)
        {
            return ThanhToan_DAL.TinhTienDuKien(thoiGianBatDau, thoiGianKetThuc, donGiaGio, tienDV, giamGia);
        }
    }
}
