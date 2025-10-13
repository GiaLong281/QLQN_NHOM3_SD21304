using System;
using System.Data;
using DAL_QuanLyQuanNet;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_QuanLyQuanNet
{
    public class ThongKe_BLL
    {
        private readonly ThongKe_DAL dal = new ThongKe_DAL();

        public DataTable LayDoanhThuTheoNgay(DateTime from, DateTime to)
        {
            return dal.LayDoanhThuTheoNgay(from, to);
        }
        public DataTable LayTiLeChonMay(DateTime from, DateTime to)
        {
            return dal.LayTiLeChonMay(from, to);
        }
        public DataTable LayDoanhThuNhanVien(DateTime from, DateTime to)
        {
            return dal.LayDoanhThuNhanVien(from, to);
        }
    }
}
