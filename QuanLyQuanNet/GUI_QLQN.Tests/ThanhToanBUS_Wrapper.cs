using System;
using System.Data;
using System.Collections.Generic;
using BUS_QuanLyQuanNet;
using DTO_QuanLyQuanNet;

namespace GUI_QLQN.Tests
{
    public class ThanhToanBUS_Wrapper
    {
        private readonly IThanhToanDAL_Test _thanhToanDAL;
        private readonly ThanhToan_BUS _thanhToanBUS;

        public ThanhToanBUS_Wrapper(IThanhToanDAL_Test thanhToanDAL = null)
        {
            _thanhToanDAL = thanhToanDAL ?? new ThanhToanDAL_Adapter();
            _thanhToanBUS = new ThanhToan_BUS();
        }

        // Wrapper methods for testing
        public List<ThanhToan_DTO> LayTatCaThanhToan()
        {
            if (_thanhToanDAL != null)
                return _thanhToanDAL.LayTatCa();
            else
                return ThanhToan_BUS.LayTatCa();
        }

        public DataTable LayLichSuThanhToan()
        {
            if (_thanhToanDAL != null)
                return _thanhToanDAL.LayLichSuThanhToan();
            else
                return ThanhToan_BUS.LayLichSuThanhToan();
        }

        public ThanhToan_DTO LayThanhToanTheoMa(string ma)
        {
            if (_thanhToanDAL != null)
                return _thanhToanDAL.LayTheoMa(ma);
            else
                return ThanhToan_BUS.LayTheoMa(ma);
        }

        public List<ThanhToan_DTO> TimKiemThanhToan(string ma)
        {
            if (_thanhToanDAL != null)
                return _thanhToanDAL.TimKiemTheoMa(ma);
            else
                return ThanhToan_BUS.TimKiem(ma);
        }

        public (bool Success, string Message, decimal SoGio, decimal TienGio, decimal TienDV, decimal GiamGia, decimal TongPhaiTra)
        ThanhToanCoKhuyenMai(string maPhien, decimal donGiaGio)
        {
            if (_thanhToanDAL != null)
                return _thanhToanDAL.ThanhToanCoKhuyenMai(maPhien, donGiaGio);
            else
                return _thanhToanBUS.ThanhToanCoKhuyenMai(maPhien, donGiaGio);
        }

        public (bool Success, string Message, decimal SoGio, decimal TienGio, decimal TienDV, decimal GiamGia, decimal TongCanThu)
        TinhTienXuatHoaDon(string maPhien, decimal donGiaGio)
        {
            if (_thanhToanDAL != null)
                return _thanhToanDAL.TinhTienXuatHoaDon(maPhien, donGiaGio);
            else
                return _thanhToanBUS.TinhTienXuatHoaDon(maPhien, donGiaGio);
        }

        public (bool Success, string Message, decimal SoGio, decimal TienGio, decimal TienDV, decimal GiamGia, decimal TongPhaiTra)
        TinhTienDuKien(DateTime thoiGianBatDau, DateTime thoiGianKetThuc, decimal donGiaGio, decimal tienDV = 0, decimal giamGia = 0)
        {
            if (_thanhToanDAL != null)
                return _thanhToanDAL.TinhTienDuKien(thoiGianBatDau, thoiGianKetThuc, donGiaGio, tienDV, giamGia);
            else
                return ThanhToan_BUS.TinhTienDuKien(thoiGianBatDau, thoiGianKetThuc, donGiaGio, tienDV, giamGia);
        }

        // Helper methods for testing
        public bool KiemTraMaPhienHopLe(string maPhien)
        {
            return !string.IsNullOrEmpty(maPhien) && maPhien.Length >= 2;
        }

        public bool KiemTraDonGiaHopLe(decimal donGia)
        {
            return donGia > 0;
        }

        public bool KiemTraThoiGianHopLe(DateTime from, DateTime to)
        {
            return from <= to && from <= DateTime.Now;
        }
    }
}