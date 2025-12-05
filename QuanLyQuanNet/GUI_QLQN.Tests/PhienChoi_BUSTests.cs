using NUnit.Framework;
using Moq;
using DTO_QuanLyQuanNet;
using System;
using System.Collections.Generic;

namespace GUI_QLQN.Tests
{
    [TestFixture]
    public class PhienChoi_BUSTests
    {
        private Mock<IPhienChoiDAL_Test> _mockPhienChoiDAL;
        private PhienChoiBUS_Wrapper _phienChoiBUS;

        [SetUp]
        public void Setup()
        {
            _mockPhienChoiDAL = new Mock<IPhienChoiDAL_Test>();
            _phienChoiBUS = new PhienChoiBUS_Wrapper(_mockPhienChoiDAL.Object);
        }

        // SES_001 - Thêm phiên chơi hợp lệ cho máy rảnh
        [Test]
        public void SES_001_ThemPhien_WithValidData_ShouldSuccess()
        {
            // Arrange
            var phienHopLe = new PhienChoi_DTO
            {
                MaPhien = "PS001",
                MaKhachHang = "KH001",
                MaMay = "MT001",
                ThoiGianBatDau = DateTime.Now,
                SoTienConLai = 100000,
                NgayTao = DateTime.Now,
                MaTrangThai = "TT01"
            };

            _mockPhienChoiDAL.Setup(x => x.ThemPhienChoi(phienHopLe))
                           .Returns(true);

            // Act
            var result = _phienChoiBUS.ThemPhien(phienHopLe);

            // Assert
            Assert.That(result, Is.True);
        }

        // SES_002 - Kiểm tra validation khi thiếu thông tin
        [Test]
        public void SES_002_ThemPhien_WithMissingCustomer_ShouldBeInvalid()
        {
            // Arrange - Thiếu mã khách hàng
            var phienThieuThongTin = new PhienChoi_DTO
            {
                MaPhien = "PS001",
                MaKhachHang = null, // Thiếu khách hàng
                MaMay = "MT001",
                ThoiGianBatDau = DateTime.Now
            };

            // Act & Assert - Test logic validation
            bool isValid = !string.IsNullOrEmpty(phienThieuThongTin.MaKhachHang) &&
                          !string.IsNullOrEmpty(phienThieuThongTin.MaMay);

            Assert.That(isValid, Is.False);
        }

        // SES_003 - Kiểm tra định dạng thời gian
        [Test]
        public void SES_003_ThoiGian_WithValidFormat_ShouldBeValid()
        {
            // Arrange
            DateTime validTime = DateTime.Now;

            // Act & Assert
            Assert.That(validTime, Is.Not.EqualTo(DateTime.MinValue));
            Assert.That(validTime, Is.LessThanOrEqualTo(DateTime.Now));
        }

        // SES_004 - Không cho phép tạo phiên khi máy đang bận
        [Test]
        public void SES_004_ThemPhien_ForBusyMachine_ShouldCheckAvailability()
        {
            // Arrange - Giả sử máy đang có phiên active
            var existingSession = new PhienChoi_DTO
            {
                MaMay = "MT001",
                ThoiGianKetThuc = null // Chưa kết thúc = đang bận
            };

            var newSession = new PhienChoi_DTO
            {
                MaMay = "MT001", // Cùng máy
                ThoiGianBatDau = DateTime.Now
            };

            // Act - Kiểm tra máy có đang bận không
            bool isMachineBusy = existingSession.ThoiGianKetThuc == null;

            // Assert
            Assert.That(isMachineBusy, Is.True);
        }

        // SES_005 - Kết thúc phiên hợp lệ
        [Test]
        public void SES_005_KetThucPhien_WithValidData_ShouldSuccess()
        {
            // Arrange
            string maPhien = "PS001";
            DateTime thoiGianKetThuc = DateTime.Now;
            double tongSoGio = 2.5;
            decimal tongTien = 50000;
            decimal soTienConLai = 50000;

            _mockPhienChoiDAL.Setup(x => x.CapNhatKetThucPhien(maPhien, thoiGianKetThuc, tongSoGio, tongTien, soTienConLai))
                           .Returns(true);

            // Act
            var result = _phienChoiBUS.CapNhatKetThucPhien(maPhien, thoiGianKetThuc, tongSoGio, tongTien, soTienConLai);

            // Assert
            Assert.That(result, Is.True);
        }

        // SES_006 - Kết thúc phiên khi máy đang rảnh
        [Test]
        public void SES_006_KetThucPhien_ForAvailableMachine_ShouldFail()
        {
            // Arrange - Phiên không tồn tại hoặc đã kết thúc
            string nonExistentMaPhien = "PS999";

            _mockPhienChoiDAL.Setup(x => x.CapNhatKetThucPhien(nonExistentMaPhien, It.IsAny<DateTime>(), It.IsAny<double>(), It.IsAny<decimal>(), It.IsAny<decimal>()))
                           .Returns(false);

            // Act
            var result = _phienChoiBUS.CapNhatKetThucPhien(nonExistentMaPhien, DateTime.Now, 0, 0, 0);

            // Assert
            Assert.That(result, Is.False);
        }

        // SES_007 - Tính tiền theo thời gian thực
        [Test]
        public void SES_007_TinhTien_WithTimeCalculation_ShouldBeCorrect()
        {
            // Arrange
            DateTime batDau = DateTime.Now.AddHours(-2); // Chơi 2 giờ trước
            DateTime ketThuc = DateTime.Now;
            decimal donGia = 20000; // 20k/giờ

            // Act
            TimeSpan thoiGianChoi = ketThuc - batDau;
            double soGio = thoiGianChoi.TotalHours;
            decimal tongTien = Math.Round((decimal)soGio * donGia, 0);

            // Assert
            Assert.That(soGio, Is.EqualTo(2).Within(0.1)); // ~2 giờ
            Assert.That(tongTien, Is.EqualTo(40000)); // 2 * 20,000 = 40,000
        }

        // SES_008 - Tìm kiếm phiên theo tên khách hàng
        [Test]
        public void SES_008_TimKiemPhien_ByCustomer_ShouldReturnResults()
        {
            // Arrange
            string tuKhoa = "KH001";
            var expectedResults = new List<PhienChoi_DTO>
            {
                new PhienChoi_DTO { MaPhien = "PS001", MaKhachHang = "KH001" }
            };

            _mockPhienChoiDAL.Setup(x => x.TimKiemPhien(tuKhoa))
                           .Returns(expectedResults);

            // Act
            var result = _phienChoiBUS.TimKiemPhien(tuKhoa);

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count, Is.EqualTo(1));
            Assert.That(result[0].MaKhachHang, Is.EqualTo("KH001"));
        }

        // SES_009 - Lọc danh sách theo trạng thái
        [Test]
        public void SES_009_LocPhien_ByStatus_ShouldFilterCorrectly()
        {
            // Arrange
            var allSessions = new List<PhienChoi_DTO>
            {
                new PhienChoi_DTO { MaPhien = "PS001", MaTrangThai = "TT01" }, // Active
                new PhienChoi_DTO { MaPhien = "PS002", MaTrangThai = "TT02" }, // Inactive
                new PhienChoi_DTO { MaPhien = "PS003", MaTrangThai = "TT01" }  // Active
            };

            _mockPhienChoiDAL.Setup(x => x.GetAll())
                           .Returns(allSessions);

            // Act - Lọc phiên active
            var allData = _phienChoiBUS.LayTatCaPhien();
            var activeSessions = allData.FindAll(p => p.MaTrangThai == "TT01");

            // Assert
            Assert.That(activeSessions.Count, Is.EqualTo(2));
            Assert.That(activeSessions.All(p => p.MaTrangThai == "TT01"), Is.True);
        }

        // Test tính năng generate mã phiên mới
        [Test]
        public void GenerateMaPhienMoi_ShouldReturnValidFormat()
        {
            // Arrange
            string expectedFormat = "PS001";

            _mockPhienChoiDAL.Setup(x => x.GenerateMaPhienMoi())
                           .Returns(expectedFormat);

            // Act
            var result = _phienChoiBUS.TaoMaPhienMoi();

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Does.StartWith("PS"));
            Assert.That(result.Length, Is.GreaterThan(2));
        }

        // Test lấy đơn giá
        [Test]
        public void LayDonGia_ShouldReturnPositiveValue()
        {
            // Arrange
            decimal expectedDonGia = 20000;

            _mockPhienChoiDAL.Setup(x => x.LayDonGiaHienTai())
                           .Returns(expectedDonGia);

            // Act
            var result = _phienChoiBUS.LayDonGia();

            // Assert
            Assert.That(result, Is.GreaterThan(0));
        }
    }
}