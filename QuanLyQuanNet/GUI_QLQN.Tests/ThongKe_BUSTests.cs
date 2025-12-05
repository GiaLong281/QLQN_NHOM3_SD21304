using NUnit.Framework;
using Moq;
using System;
using System.Data;
using System.Collections.Generic;

namespace GUI_QLQN.Tests
{
    [TestFixture]
    public class ThongKe_BUSTests
    {
        private Mock<IThongKeDAL_Test> _mockThongKeDAL;
        private ThongKeBUS_Wrapper _thongKeBUS;

        [SetUp]
        public void Setup()
        {
            _mockThongKeDAL = new Mock<IThongKeDAL_Test>();
            _thongKeBUS = new ThongKeBUS_Wrapper(_mockThongKeDAL.Object);
        }

        // REP_001 - Kiểm tra hiển thị tổng doanh thu theo ngày
        [Test]
        public void REP_001_ThongKeDoanhThuTheoNgay_WithValidDate_ShouldReturnData()
        {
            // Arrange
            var from = new DateTime(2025, 11, 15);
            var to = new DateTime(2025, 11, 15);

            var dataTable = CreateDoanhThuDataTable();
            dataTable.Rows.Add(new DateTime(2025, 11, 15), 125000);

            _mockThongKeDAL.Setup(x => x.LayDoanhThuTheoNgay(from, to))
                         .Returns(dataTable);

            // Act
            var result = _thongKeBUS.LayDoanhThuTheoNgay(from, to);
            var tongDoanhThu = _thongKeBUS.TinhTongDoanhThu(result);

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Rows.Count, Is.EqualTo(1));
            Assert.That(tongDoanhThu, Is.EqualTo(125000));
        }

        // REP_002 - Kiểm tra thống kê theo khoảng thời gian
        [Test]
        public void REP_002_ThongKeTheoKhoangThoiGian_ShouldReturnMultipleDays()
        {
            // Arrange
            var from = new DateTime(2025, 11, 10);
            var to = new DateTime(2025, 11, 15);

            var dataTable = CreateDoanhThuDataTable();
            dataTable.Rows.Add(new DateTime(2025, 11, 10), 100000);
            dataTable.Rows.Add(new DateTime(2025, 11, 11), 120000);
            dataTable.Rows.Add(new DateTime(2025, 11, 12), 150000);
            dataTable.Rows.Add(new DateTime(2025, 11, 13), 130000);
            dataTable.Rows.Add(new DateTime(2025, 11, 14), 140000);
            dataTable.Rows.Add(new DateTime(2025, 11, 15), 125000);

            _mockThongKeDAL.Setup(x => x.LayDoanhThuTheoNgay(from, to))
                         .Returns(dataTable);

            // Act
            var result = _thongKeBUS.LayDoanhThuTheoNgay(from, to);
            var tongDoanhThu = _thongKeBUS.TinhTongDoanhThu(result);

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Rows.Count, Is.EqualTo(6));
            Assert.That(tongDoanhThu, Is.EqualTo(765000)); // 100+120+150+130+140+125
        }

        // REP_003 - Kiểm tra nhập sai định dạng ngày
        [Test]
        public void REP_003_ThongKe_WithInvalidDateRange_ShouldHandleGracefully()
        {
            // Arrange - Ngày bắt đầu lớn hơn ngày kết thúc
            var from = new DateTime(2025, 11, 20);
            var to = new DateTime(2025, 11, 15);

            // Act
            var isValid = _thongKeBUS.KiemTraNgayHopLe(from, to);

            // Assert
            Assert.That(isValid, Is.False);
        }

        // REP_004 - Kiểm tra thống kê tỉ lệ chọn máy
        [Test]
        public void REP_004_ThongKeTiLeChonMay_ShouldReturnMachineData()
        {
            // Arrange
            var from = new DateTime(2025, 11, 15);
            var to = new DateTime(2025, 11, 15);

            var dataTable = CreateTiLeMayDataTable();
            dataTable.Rows.Add("Máy số 1", 15);
            dataTable.Rows.Add("Máy số 2", 10);
            dataTable.Rows.Add("Máy số 3", 20);

            _mockThongKeDAL.Setup(x => x.LayTiLeChonMay(from, to))
                         .Returns(dataTable);

            // Act
            var result = _thongKeBUS.LayTiLeChonMay(from, to);

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Rows.Count, Is.EqualTo(3));
            Assert.That(Convert.ToInt32(result.Rows[0]["SoLuotSuDung"]), Is.EqualTo(15));
        }

        // REP_005 - Kiểm tra máy không có lượt sử dụng
        [Test]
        public void REP_005_ThongKeTiLeMay_WithNoData_ShouldReturnEmpty()
        {
            // Arrange
            var from = new DateTime(2024, 1, 1);
            var to = new DateTime(2024, 1, 2);

            var dataTable = CreateTiLeMayDataTable(); // Empty table

            _mockThongKeDAL.Setup(x => x.LayTiLeChonMay(from, to))
                         .Returns(dataTable);

            // Act
            var result = _thongKeBUS.LayTiLeChonMay(from, to);

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Rows.Count, Is.EqualTo(0));
        }

        // REP_006 - Kiểm tra thống kê doanh thu theo nhân viên
        [Test]
        public void REP_006_ThongKeDoanhThuNhanVien_ShouldReturnStaffRevenue()
        {
            // Arrange
            var from = new DateTime(2025, 11, 15);
            var to = new DateTime(2025, 11, 15);

            var dataTable = CreateDoanhThuNhanVienDataTable();
            dataTable.Rows.Add("Admin User", 85000);
            dataTable.Rows.Add("Staff User", 40000);

            _mockThongKeDAL.Setup(x => x.LayDoanhThuNhanVien(from, to))
                         .Returns(dataTable);

            // Act
            var result = _thongKeBUS.LayDoanhThuNhanVien(from, to);
            var tongDoanhThu = _thongKeBUS.TinhTongDoanhThu(result);

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Rows.Count, Is.EqualTo(2));
            Assert.That(tongDoanhThu, Is.EqualTo(125000));
        }

        // REP_007 - Kiểm tra nhân viên không có doanh thu
        [Test]
        public void REP_007_ThongKeNhanVien_WithNoRevenue_ShouldReturnEmpty()
        {
            // Arrange
            var from = new DateTime(2024, 1, 1);
            var to = new DateTime(2024, 1, 2);

            var dataTable = CreateDoanhThuNhanVienDataTable(); // Empty table

            _mockThongKeDAL.Setup(x => x.LayDoanhThuNhanVien(from, to))
                         .Returns(dataTable);

            // Act
            var result = _thongKeBUS.LayDoanhThuNhanVien(from, to);

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Rows.Count, Is.EqualTo(0));
        }

        // REP_008 - Kiểm tra dữ liệu cho biểu đồ doanh thu
        [Test]
        public void REP_008_ThongKeDoanhThu_ForChart_ShouldHaveCorrectDataStructure()
        {
            // Arrange
            var from = new DateTime(2025, 11, 10);
            var to = new DateTime(2025, 11, 12);

            var dataTable = CreateDoanhThuDataTable();
            dataTable.Rows.Add(new DateTime(2025, 11, 10), 100000);
            dataTable.Rows.Add(new DateTime(2025, 11, 11), 120000);
            dataTable.Rows.Add(new DateTime(2025, 11, 12), 150000);

            _mockThongKeDAL.Setup(x => x.LayDoanhThuTheoNgay(from, to))
                         .Returns(dataTable);

            // Act
            var result = _thongKeBUS.LayDoanhThuTheoNgay(from, to);

            // Assert - Kiểm tra cấu trúc dữ liệu cho biểu đồ
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Columns.Contains("Ngay"), Is.True);
            Assert.That(result.Columns.Contains("TongTien"), Is.True);
            Assert.That(result.Rows.Count, Is.EqualTo(3));

            // Kiểm tra tất cả số tiền đều >= 0
            foreach (DataRow row in result.Rows)
            {
                Assert.That(Convert.ToDecimal(row["TongTien"]), Is.GreaterThanOrEqualTo(0));
            }
        }

        // REP_009 - Kiểm tra không có dữ liệu
        [Test]
        public void REP_009_ThongKe_WithNoData_ShouldReturnEmptyTables()
        {
            // Arrange
            var from = new DateTime(2024, 1, 1);
            var to = new DateTime(2024, 1, 2);

            var emptyDoanhThuTable = CreateDoanhThuDataTable();
            var emptyTiLeMayTable = CreateTiLeMayDataTable();
            var emptyNhanVienTable = CreateDoanhThuNhanVienDataTable();

            _mockThongKeDAL.Setup(x => x.LayDoanhThuTheoNgay(from, to))
                         .Returns(emptyDoanhThuTable);
            _mockThongKeDAL.Setup(x => x.LayTiLeChonMay(from, to))
                         .Returns(emptyTiLeMayTable);
            _mockThongKeDAL.Setup(x => x.LayDoanhThuNhanVien(from, to))
                         .Returns(emptyNhanVienTable);

            // Act
            var resultDoanhThu = _thongKeBUS.LayDoanhThuTheoNgay(from, to);
            var resultTiLeMay = _thongKeBUS.LayTiLeChonMay(from, to);
            var resultNhanVien = _thongKeBUS.LayDoanhThuNhanVien(from, to);

            // Assert
            Assert.That(resultDoanhThu.Rows.Count, Is.EqualTo(0));
            Assert.That(resultTiLeMay.Rows.Count, Is.EqualTo(0));
            Assert.That(resultNhanVien.Rows.Count, Is.EqualTo(0));
        }

        // REP_012 - Kiểm tra tốc độ tải dữ liệu lớn
        [Test]
        public void REP_012_ThongKe_WithLargeData_ShouldLoadQuickly()
        {
            // Arrange
            var from = new DateTime(2025, 1, 1);
            var to = new DateTime(2025, 12, 31);

            var largeDataTable = CreateDoanhThuDataTable();
            for (int i = 0; i < 500; i++)
            {
                largeDataTable.Rows.Add(from.AddDays(i), 100000 + (i * 1000));
            }

            _mockThongKeDAL.Setup(x => x.LayDoanhThuTheoNgay(from, to))
                         .Returns(largeDataTable);

            // Act & Assert - Đo thời gian thực thi
            var startTime = DateTime.Now;
            var result = _thongKeBUS.LayDoanhThuTheoNgay(from, to);
            var endTime = DateTime.Now;
            var executionTime = (endTime - startTime).TotalSeconds;

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Rows.Count, Is.EqualTo(500));
            Assert.That(executionTime, Is.LessThan(5)); // Dưới 5 giây
        }

        // REP_014 - Kiểm tra tổng cộng doanh thu
        [Test]
        public void REP_014_TongCongDoanhThu_ShouldCalculateCorrectly()
        {
            // Arrange
            var from = new DateTime(2025, 11, 15);
            var to = new DateTime(2025, 11, 15);

            var dataTable = CreateDoanhThuDataTable();
            dataTable.Rows.Add(new DateTime(2025, 11, 15), 125000);

            _mockThongKeDAL.Setup(x => x.LayDoanhThuTheoNgay(from, to))
                         .Returns(dataTable);

            // Act
            var result = _thongKeBUS.LayDoanhThuTheoNgay(from, to);
            var tongDoanhThu = _thongKeBUS.TinhTongDoanhThu(result);

            // Assert
            Assert.That(tongDoanhThu, Is.EqualTo(125000));
        }

        // Helper methods để tạo DataTable
        private DataTable CreateDoanhThuDataTable()
        {
            var dt = new DataTable();
            dt.Columns.Add("Ngay", typeof(DateTime));
            dt.Columns.Add("TongTien", typeof(decimal));
            return dt;
        }

        private DataTable CreateTiLeMayDataTable()
        {
            var dt = new DataTable();
            dt.Columns.Add("TenMay", typeof(string));
            dt.Columns.Add("SoLuotSuDung", typeof(int));
            return dt;
        }

        private DataTable CreateDoanhThuNhanVienDataTable()
        {
            var dt = new DataTable();
            dt.Columns.Add("HoTen", typeof(string));
            dt.Columns.Add("TongTien", typeof(decimal));
            return dt;
        }

        // Test validation ngày
        [Test]
        public void KiemTraNgayHopLe_WithValidDates_ShouldReturnTrue()
        {
            // Arrange
            var from = new DateTime(2025, 11, 1);
            var to = new DateTime(2025, 11, 15);

            // Act
            var isValid = _thongKeBUS.KiemTraNgayHopLe(from, to);

            // Assert
            Assert.That(isValid, Is.True);
        }

        [Test]
        public void KiemTraNgayHopLe_WithFromAfterTo_ShouldReturnFalse()
        {
            // Arrange
            var from = new DateTime(2025, 11, 20);
            var to = new DateTime(2025, 11, 15);

            // Act
            var isValid = _thongKeBUS.KiemTraNgayHopLe(from, to);

            // Assert
            Assert.That(isValid, Is.False);
        }
    }
}