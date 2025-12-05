using NUnit.Framework;
using Moq;
using DTO_QuanLyQuanNet;

namespace GUI_QLQN.Tests
{
    [TestFixture]
    public class NhanVien_BUSTests
    {
        private Mock<INhanVienDAL_Test> _mockNhanVienDAL;
        private NhanVienBUS_Wrapper _nhanVienBUS;

        [SetUp]
        public void Setup()
        {
            _mockNhanVienDAL = new Mock<INhanVienDAL_Test>();
            _nhanVienBUS = new NhanVienBUS_Wrapper(_mockNhanVienDAL.Object);
        }

        [Test]
        public void AUTH_001_DangNhap_ValidAdmin_ShouldReturnAdminUser()
        {
            // Arrange
            string maNV = "NV001";
            string password = "P@ssw0rd123";
            var expectedUser = new NhanVien_DTO
            {
                MaNhanVien = maNV,
                HoTen = "Admin User",
                MaChucVu = "CV01"
            };

            _mockNhanVienDAL.Setup(x => x.KiemTraDangNhap(maNV, password))
                           .Returns(expectedUser);

            // Act
            var result = _nhanVienBUS.DangNhap(maNV, password);

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result.MaChucVu, Is.EqualTo("CV01"));
        }

        [Test]
        public void AUTH_002_DangNhap_InvalidPassword_ShouldReturnNull()
        {
            // Arrange
            string maNV = "NV001";
            string wrongPassword = "wrongpassword";

            // FIX: Sử dụng default! thay vì (NhanVien_DTO)null
            _mockNhanVienDAL.Setup(x => x.KiemTraDangNhap(maNV, wrongPassword))
                           .Returns(default(NhanVien_DTO)!); // Thêm ! ở cuối

            // Act
            var result = _nhanVienBUS.DangNhap(maNV, wrongPassword);

            // Assert
            Assert.That(result, Is.Null);
        }

        [Test]
        public void AUTH_010_DangNhap_ValidStaff_ShouldReturnStaffUser()
        {
            // Arrange
            string maNV = "NV002";
            string password = "123456";
            var expectedUser = new NhanVien_DTO
            {
                MaNhanVien = maNV,
                HoTen = "Staff User",
                MaChucVu = "CV02"
            };

            _mockNhanVienDAL.Setup(x => x.KiemTraDangNhap(maNV, password))
                           .Returns(expectedUser);

            // Act
            var result = _nhanVienBUS.DangNhap(maNV, password);

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result.MaChucVu, Is.EqualTo("CV02"));
        }
    }
}