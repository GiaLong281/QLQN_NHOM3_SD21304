using System;
using System.Data;
using System.Collections.Generic;
using DTO_QuanLyQuanNet;

namespace GUI_QLQN.Tests
{
    public static class ThanhToanTestDataHelper
    {
        public static DataTable CreateSampleLichSuThanhToan()
        {
            var dt = new DataTable();
            dt.Columns.Add("MaPhien", typeof(string));
            dt.Columns.Add("MaKhachHang", typeof(string));
            dt.Columns.Add("TenKhachHang", typeof(string));
            dt.Columns.Add("MaMay", typeof(string));
            dt.Columns.Add("ThoiGianBatDau", typeof(DateTime));
            dt.Columns.Add("ThoiGianKetThuc", typeof(DateTime));
            dt.Columns.Add("TongSoGio", typeof(double));
            dt.Columns.Add("TongTien", typeof(decimal));
            dt.Columns.Add("TongTienDichVu", typeof(decimal));
            dt.Columns.Add("KhuyenMai", typeof(decimal));
            dt.Columns.Add("SoTienConLai", typeof(decimal));
            dt.Columns.Add("TenTrangThai", typeof(string));

            dt.Rows.Add("PC001", "KH001", "Nguyễn Văn A", "MT001",
                DateTime.Now.AddHours(-2), DateTime.Now, 2.0, 15000, 5000, 0, 15000, "Chưa thanh toán");
            dt.Rows.Add("PC002", "KH002", "Trần Thị B", "MT002",
                DateTime.Now.AddHours(-3), DateTime.Now, 3.0, 20000, 3000, 2000, 21000, "Đã thanh toán");

            return dt;
        }

        public static List<ThanhToan_DTO> CreateSampleThanhToanList()
        {
            return new List<ThanhToan_DTO>
            {
                new ThanhToan_DTO
                {
                    MaThanhToan = "TT001",
                    MaKhachHang = "KH001",
                    TongTien = 15000,
                    ThoiGianThanhToan = DateTime.Now,
                    NgayTao = DateTime.Now
                },
                new ThanhToan_DTO
                {
                    MaThanhToan = "TT002",
                    MaKhachHang = "KH002",
                    TongTien = 21000,
                    ThoiGianThanhToan = DateTime.Now.AddHours(-1),
                    NgayTao = DateTime.Now.AddHours(-1)
                }
            };
        }
    }
}