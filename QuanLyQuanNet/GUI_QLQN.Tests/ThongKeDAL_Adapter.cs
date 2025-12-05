using System;
using System.Data;
using DAL_QuanLyQuanNet;

namespace GUI_QLQN.Tests
{
    public class ThongKeDAL_Adapter : IThongKeDAL_Test
    {
        private readonly ThongKe_DAL _thongKeDAL = new ThongKe_DAL();

        public DataTable LayDoanhThuTheoNgay(DateTime from, DateTime to)
            => _thongKeDAL.LayDoanhThuTheoNgay(from, to);

        public DataTable LayTiLeChonMay(DateTime from, DateTime to)
            => _thongKeDAL.LayTiLeChonMay(from, to);

        public DataTable LayDoanhThuNhanVien(DateTime from, DateTime to)
            => _thongKeDAL.LayDoanhThuNhanVien(from, to);

        public DataTable GetAll()
            => _thongKeDAL.GetAll();
    }
}