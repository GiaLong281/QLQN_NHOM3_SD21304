using System;
using System.Data;
using System.Collections.Generic;

namespace GUI_QLQN.Tests
{
    public interface IThongKeDAL_Test
    {
        DataTable LayDoanhThuTheoNgay(DateTime from, DateTime to);
        DataTable LayTiLeChonMay(DateTime from, DateTime to);
        DataTable LayDoanhThuNhanVien(DateTime from, DateTime to);
        DataTable GetAll();
    }
}