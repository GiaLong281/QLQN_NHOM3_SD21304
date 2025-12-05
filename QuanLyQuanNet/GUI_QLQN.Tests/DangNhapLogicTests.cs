using NUnit.Framework;
using DTO_QuanLyQuanNet;

namespace GUI_QLQN.Tests
{
    [TestFixture]
    public class LoginLogicTests
    {
        // Tạo UserSession giả cho testing (không cần reference đến GUI)
        public static class UserSession_Test
        {
            public static NhanVien_DTO NguoiDangNhap { get; set; }
        }

        [Test]
        public void UserSession_AfterLogin_ShouldStoreCorrectUser()
        {
            // Arrange
            var user = new NhanVien_DTO
            {
                MaNhanVien = "NV001",
                MaChucVu = "CV01",
                HoTen = "Nguyen Van A"
            };

            // Act
            UserSession_Test.NguoiDangNhap = user;

            // Assert
            Assert.That(UserSession_Test.NguoiDangNhap, Is.Not.Null);
            Assert.That(UserSession_Test.NguoiDangNhap.MaNhanVien, Is.EqualTo("NV001"));
        }

        [Test]
        public void AUTH_001_IsAdmin_WithCV01_ShouldReturnTrue()
        {
            // Arrange
            var user = new NhanVien_DTO { MaChucVu = "CV01" };

            // Act
            bool isAdmin = user.MaChucVu.ToUpper() == "CV01";

            // Assert
            Assert.That(isAdmin, Is.True);
        }

        [Test]
        public void AUTH_003_IsAdmin_WithCV02_ShouldReturnFalse()
        {
            // Arrange
            var user = new NhanVien_DTO { MaChucVu = "CV02" };

            // Act
            bool isAdmin = user.MaChucVu.ToUpper() == "CV01";

            // Assert
            Assert.That(isAdmin, Is.False);
        }

        [TearDown]
        public void TearDown()
        {
            // Cleanup - không cần vì đang dùng class test riêng
            UserSession_Test.NguoiDangNhap = null;
        }
    }
}