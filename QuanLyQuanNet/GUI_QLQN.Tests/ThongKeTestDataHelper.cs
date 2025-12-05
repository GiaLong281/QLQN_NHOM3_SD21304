using System;
using System.Data;

namespace GUI_QLQN.Tests
{
    public static class ThongKeTestDataHelper
    {
        public static DataTable CreateSampleDoanhThuData()
        {
            var dt = new DataTable();
            dt.Columns.Add("Ngay", typeof(DateTime));
            dt.Columns.Add("TongTien", typeof(decimal));

            dt.Rows.Add(new DateTime(2025, 11, 10), 100000);
            dt.Rows.Add(new DateTime(2025, 11, 11), 120000);
            dt.Rows.Add(new DateTime(2025, 11, 12), 150000);

            return dt;
        }

        public static DataTable CreateSampleTiLeMayData()
        {
            var dt = new DataTable();
            dt.Columns.Add("TenMay", typeof(string));
            dt.Columns.Add("SoLuotSuDung", typeof(int));

            dt.Rows.Add("Máy số 1", 25);
            dt.Rows.Add("Máy số 2", 18);
            dt.Rows.Add("Máy số 3", 32);

            return dt;
        }

        public static DataTable CreateSampleDoanhThuNhanVienData()
        {
            var dt = new DataTable();
            dt.Columns.Add("HoTen", typeof(string));
            dt.Columns.Add("TongTien", typeof(decimal));

            dt.Rows.Add("Nguyễn Văn A", 85000);
            dt.Rows.Add("Trần Thị B", 40000);

            return dt;
        }
    }
}