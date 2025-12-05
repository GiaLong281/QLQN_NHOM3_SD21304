using System;
using System.Data;
using BLL_QuanLyQuanNet;

namespace GUI_QLQN.Tests
{
    public class ThongKeBUS_Wrapper
    {
        private readonly IThongKeDAL_Test _thongKeDAL;
        private readonly ThongKe_BLL _thongKeBLL;

        public ThongKeBUS_Wrapper(IThongKeDAL_Test thongKeDAL = null)
        {
            _thongKeDAL = thongKeDAL ?? new ThongKeDAL_Adapter();
            _thongKeBLL = new ThongKe_BLL();
        }

        // Wrapper methods for testing
        public DataTable LayDoanhThuTheoNgay(DateTime from, DateTime to)
        {
            if (_thongKeDAL != null)
                return _thongKeDAL.LayDoanhThuTheoNgay(from, to);
            else
                return _thongKeBLL.LayDoanhThuTheoNgay(from, to);
        }

        public DataTable LayTiLeChonMay(DateTime from, DateTime to)
        {
            if (_thongKeDAL != null)
                return _thongKeDAL.LayTiLeChonMay(from, to);
            else
                return _thongKeBLL.LayTiLeChonMay(from, to);
        }

        public DataTable LayDoanhThuNhanVien(DateTime from, DateTime to)
        {
            if (_thongKeDAL != null)
                return _thongKeDAL.LayDoanhThuNhanVien(from, to);
            else
                return _thongKeBLL.LayDoanhThuNhanVien(from, to);
        }

        // Helper methods for testing
        public decimal TinhTongDoanhThu(DataTable data)
        {
            decimal tong = 0;
            foreach (DataRow row in data.Rows)
            {
                tong += Convert.ToDecimal(row["TongTien"]);
            }
            return tong;
        }

        public bool KiemTraNgayHopLe(DateTime from, DateTime to)
        {
            return from <= to && from <= DateTime.Now && to <= DateTime.Now;
        }
    }
}