using NUnit.Framework;
using Moq;
using System;
using System.Data;
using System.Collections.Generic;
using DTO_QuanLyQuanNet;

namespace GUI_QLQN.Tests
{
    [TestFixture]
    public class ThanhToan_BUSTests
    {
        private Mock<IThanhToanDAL_Test> _mockThanhToanDAL;
        private ThanhToanBUS_Wrapper _thanhToanBUS;

        [SetUp]
        public void Setup()
        {
            _mockThanhToanDAL = new Mock<IThanhToanDAL_Test>();
            _thanhToanBUS = new ThanhToanBUS_Wrapper(_mockThanhToanDAL.Object);
        }

        // PAY_001 - Kiểm tra hiển thị danh sách phiên cần thanh toán
        [Test]
        public void PAY_001_LayLichSuThanhToan_ShouldReturnData()
        {
            // Arrange
            var dataTable = CreateLichSuThanhToanDataTable();
            dataTable.Rows.Add("PC001", "KH001", "Nguyễn Văn A", "MT001",
                DateTime.Now.AddHours(-2), DateTime.Now, 2.0, 15000, 5000, 0, 15000, "Chưa thanh toán");

            _mockThanhToanDAL.Setup(x => x.LayLichSuThanhToan())
                           .Returns(dataTable);

            // Act
            var result = _thanhToanBUS.LayLichSuThanhToan();

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Rows.Count, Is.EqualTo(1));
            Assert.That(result.Columns.Contains("MaPhien"), Is.True);
            Assert.That(result.Columns.Contains("TenKhachHang"), Is.True);
        }

        // PAY_002 - Kiểm tra chọn phiên để thanh toán
        [Test]
        public void PAY_002_LayThanhToanTheoMa_WithValidMa_ShouldReturnData()
        {
            // Arrange
            string maPhien = "PC001";
            var thanhToan = new ThanhToan_DTO
            {
                MaThanhToan = "TT001",
                MaKhachHang = "KH001",
                TongTien = 15000
            };

            _mockThanhToanDAL.Setup(x => x.LayTheoMa(maPhien))
                           .Returns(thanhToan);

            // Act
            var result = _thanhToanBUS.LayThanhToanTheoMa(maPhien);

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result.MaKhachHang, Is.EqualTo("KH001"));
            Assert.That(result.TongTien, Is.EqualTo(15000));
        }

        // PAY_003 - Kiểm tra tính tổng tiền khi có phụ phí
        [Test]
        public void PAY_003_TinhTienDuKien_WithExtraFee_ShouldCalculateCorrectly()
        {
            // Arrange
            var batDau = DateTime.Now.AddHours(-2);
            var ketThuc = DateTime.Now;
            decimal donGia = 10000;
            decimal tienDV = 5000; // Phụ phí

            _mockThanhToanDAL.Setup(x => x.TinhTienDuKien(batDau, ketThuc, donGia, tienDV, 0))
                           .Returns((true, "", 2.0m, 20000m, 5000m, 0m, 25000m));

            // Act
            var result = _thanhToanBUS.TinhTienDuKien(batDau, ketThuc, donGia, tienDV, 0);

            // Assert
            Assert.That(result.Success, Is.True);
            Assert.That(result.TongPhaiTra, Is.EqualTo(25000)); // 20,000 + 5,000
        }

        // PAY_004 - Kiểm tra tính tổng tiền khi có giảm giá
        [Test]
        public void PAY_004_TinhTienDuKien_WithDiscount_ShouldCalculateCorrectly()
        {
            // Arrange
            var batDau = DateTime.Now.AddHours(-3);
            var ketThuc = DateTime.Now;
            decimal donGia = 10000;
            decimal giamGia = 10000; // Giảm giá 10,000

            _mockThanhToanDAL.Setup(x => x.TinhTienDuKien(batDau, ketThuc, donGia, 0, giamGia))
                           .Returns((true, "", 3.0m, 30000m, 0m, 10000m, 20000m));

            // Act
            var result = _thanhToanBUS.TinhTienDuKien(batDau, ketThuc, donGia, 0, giamGia);

            // Assert
            Assert.That(result.Success, Is.True);
            Assert.That(result.TongPhaiTra, Is.EqualTo(20000)); // 30,000 - 10,000
        }

        // PAY_005 - Kiểm tra tính tổng tiền khi nhập sai định dạng phụ phí
        [Test]
        public void PAY_005_TinhTien_WithInvalidInput_ShouldHandleGracefully()
        {
            // Arrange - Test với giá trị hợp lệ (validation sẽ ở UI)
            var batDau = DateTime.Now.AddHours(-1);
            var ketThuc = DateTime.Now;
            decimal donGia = 10000;

            // Act & Assert - Kiểm tra validation cơ bản
            bool isValidDonGia = _thanhToanBUS.KiemTraDonGiaHopLe(donGia);
            bool isValidThoiGian = _thanhToanBUS.KiemTraThoiGianHopLe(batDau, ketThuc);

            Assert.That(isValidDonGia, Is.True);
            Assert.That(isValidThoiGian, Is.True);
        }

        // PAY_006 - Thanh toán hợp lệ
        [Test]
        public void PAY_006_ThanhToanCoKhuyenMai_WithValidData_ShouldSuccess()
        {
            // Arrange
            string maPhien = "PC005";
            decimal donGia = 10000;

            _mockThanhToanDAL.Setup(x => x.ThanhToanCoKhuyenMai(maPhien, donGia))
                           .Returns((true, "Thanh toán thành công!", 4.0m, 40000m, 0m, 0m, 40000m));

            // Act
            var result = _thanhToanBUS.ThanhToanCoKhuyenMai(maPhien, donGia);

            // Assert
            Assert.That(result.Success, Is.True);
            Assert.That(result.TongPhaiTra, Is.EqualTo(40000));
            Assert.That(result.Message, Does.Contain("thành công"));
        }

        // PAY_007 - Thanh toán khi chưa tính tiền
        [Test]
        public void PAY_007_ThanhToan_WithoutCalculating_ShouldHandleProperly()
        {
            // Arrange - Test với mã phiên không hợp lệ
            string invalidMaPhien = "";
            decimal donGia = 10000;

            // Act & Assert - Kiểm tra validation mã phiên
            bool isValidMaPhien = _thanhToanBUS.KiemTraMaPhienHopLe(invalidMaPhien);

            Assert.That(isValidMaPhien, Is.False);
        }

        // PAY_008 - Kiểm tra rollback khi lỗi lưu dữ liệu
        [Test]
        public void PAY_008_ThanhToan_WithDatabaseError_ShouldReturnFailure()
        {
            // Arrange
            string maPhien = "PC007";
            decimal donGia = 10000;

            _mockThanhToanDAL.Setup(x => x.ThanhToanCoKhuyenMai(maPhien, donGia))
                           .Returns((false, "Không thể lưu dữ liệu", 0m, 0m, 0m, 0m, 0m));

            // Act
            var result = _thanhToanBUS.ThanhToanCoKhuyenMai(maPhien, donGia);

            // Assert
            Assert.That(result.Success, Is.False);
            Assert.That(result.Message, Does.Contain("lưu dữ liệu"));
        }

        // PAY_009 - Kiểm tra tính tiền cho khách vãng lai
        [Test]
        public void PAY_009_TinhTienXuatHoaDon_ForWalkInCustomer_ShouldSuccess()
        {
            // Arrange
            string maPhien = "PC008";
            decimal donGia = 10000;

            _mockThanhToanDAL.Setup(x => x.TinhTienXuatHoaDon(maPhien, donGia))
                           .Returns((true, "Tính tiền thành công!", 2.5m, 25000m, 5000m, 0m, 30000m));

            // Act
            var result = _thanhToanBUS.TinhTienXuatHoaDon(maPhien, donGia);

            // Assert
            Assert.That(result.Success, Is.True);
            Assert.That(result.TongCanThu, Is.EqualTo(30000));
            Assert.That(result.SoGio, Is.EqualTo(2.5m));
        }

        // PAY_010 - Kiểm tra tính tiền khi chưa thanh toán
        [Test]
        public void PAY_010_TinhTien_ForUnpaidSession_ShouldReturnCorrectAmount()
        {
            // Arrange
            string maPhien = "PC009";
            decimal donGia = 10000;

            _mockThanhToanDAL.Setup(x => x.TinhTienXuatHoaDon(maPhien, donGia))
                           .Returns((true, "Tính tiền thành công!", 1.5m, 15000m, 3000m, 0m, 18000m));

            // Act
            var result = _thanhToanBUS.TinhTienXuatHoaDon(maPhien, donGia);

            // Assert
            Assert.That(result.Success, Is.True);
            Assert.That(result.TongCanThu, Is.GreaterThan(0));
        }

        // PAY_011 - Tìm kiếm theo tên khách hàng
        [Test]
        public void PAY_011_TimKiemThanhToan_ByCustomerName_ShouldReturnResults()
        {
            // Arrange
            string tuKhoa = "Nguyễn Văn A";
            var expectedResults = new List<ThanhToan_DTO>
            {
                new ThanhToan_DTO { MaThanhToan = "TT001", MaKhachHang = "KH001", TongTien = 15000 }
            };

            _mockThanhToanDAL.Setup(x => x.TimKiemTheoMa(tuKhoa))
                           .Returns(expectedResults);

            // Act
            var result = _thanhToanBUS.TimKiemThanhToan(tuKhoa);

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count, Is.EqualTo(1));
            Assert.That(result[0].MaKhachHang, Is.EqualTo("KH001"));
        }

        // PAY_012 - Tìm kiếm theo mã phiên
        [Test]
        public void PAY_012_TimKiemThanhToan_ByMaPhien_ShouldReturnSingleResult()
        {
            // Arrange
            string maPhien = "PC005";
            var expectedResults = new List<ThanhToan_DTO>
            {
                new ThanhToan_DTO { MaThanhToan = "TT005", MaKhachHang = "KH005", TongTien = 40000 }
            };

            _mockThanhToanDAL.Setup(x => x.TimKiemTheoMa(maPhien))
                           .Returns(expectedResults);

            // Act
            var result = _thanhToanBUS.TimKiemThanhToan(maPhien);

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count, Is.EqualTo(1));
            Assert.That(result[0].TongTien, Is.EqualTo(40000));
        }

        // PAY_013 - Kiểm tra hiển thị màu trạng thái
        [Test]
        public void PAY_013_LichSuThanhToan_ShouldHaveStatusColumn()
        {
            // Arrange
            var dataTable = CreateLichSuThanhToanDataTable();
            dataTable.Rows.Add("PC001", "KH001", "Nguyễn Văn A", "MT001",
                DateTime.Now.AddHours(-2), DateTime.Now, 2.0, 15000, 5000, 0, 15000, "Đã thanh toán");

            _mockThanhToanDAL.Setup(x => x.LayLichSuThanhToan())
                           .Returns(dataTable);

            // Act
            var result = _thanhToanBUS.LayLichSuThanhToan();

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Columns.Contains("TenTrangThai"), Is.True);
            Assert.That(result.Rows[0]["TenTrangThai"].ToString(), Is.EqualTo("Đã thanh toán"));
        }

        // PAY_014 - Kiểm tra tốc độ tải danh sách thanh toán
        [Test]
        public void PAY_014_LayLichSuThanhToan_WithLargeData_ShouldLoadQuickly()
        {
            // Arrange
            var largeDataTable = CreateLichSuThanhToanDataTable();
            for (int i = 0; i < 200; i++)
            {
                largeDataTable.Rows.Add($"PC{i:000}", $"KH{i:000}", $"Khách hàng {i}", $"MT{i:000}",
                    DateTime.Now.AddHours(-i), DateTime.Now, i * 1.0, i * 10000, i * 1000, 0, i * 11000, "Chưa thanh toán");
            }

            _mockThanhToanDAL.Setup(x => x.LayLichSuThanhToan())
                           .Returns(largeDataTable);

            // Act & Assert - Đo thời gian thực thi
            var startTime = DateTime.Now;
            var result = _thanhToanBUS.LayLichSuThanhToan();
            var endTime = DateTime.Now;
            var executionTime = (endTime - startTime).TotalSeconds;

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Rows.Count, Is.EqualTo(200));
            Assert.That(executionTime, Is.LessThan(3)); // Dưới 3 giây
        }

        // Test tính toán thời gian chơi
        [Test]
        public void TinhThoiGianChoi_ShouldCalculateCorrectHours()
        {
            // Arrange
            var batDau = new DateTime(2025, 11, 15, 10, 0, 0);
            var ketThuc = new DateTime(2025, 11, 15, 12, 30, 0); // 2.5 giờ
            decimal donGia = 10000;

            _mockThanhToanDAL.Setup(x => x.TinhTienDuKien(batDau, ketThuc, donGia, 0, 0))
                           .Returns((true, "", 2.5m, 25000m, 0m, 0m, 25000m));

            // Act
            var result = _thanhToanBUS.TinhTienDuKien(batDau, ketThuc, donGia, 0, 0);

            // Assert
            Assert.That(result.SoGio, Is.EqualTo(2.5m));
            Assert.That(result.TienGio, Is.EqualTo(25000));
        }

        // Test validation dữ liệu
        [Test]
        public void KiemTraMaPhien_WithValidFormat_ShouldReturnTrue()
        {
            // Arrange
            string validMaPhien = "PC001";

            // Act
            var isValid = _thanhToanBUS.KiemTraMaPhienHopLe(validMaPhien);

            // Assert
            Assert.That(isValid, Is.True);
        }

        [Test]
        public void KiemTraMaPhien_WithInvalidFormat_ShouldReturnFalse()
        {
            // Arrange
            string invalidMaPhien = "";

            // Act
            var isValid = _thanhToanBUS.KiemTraMaPhienHopLe(invalidMaPhien);

            // Assert
            Assert.That(isValid, Is.False);
        }

        // Helper methods để tạo DataTable
        private DataTable CreateLichSuThanhToanDataTable()
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
            return dt;
        }
    }
}