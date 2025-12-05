using NUnit.Framework;

namespace GUI_QLQN.Tests
{
    [TestFixture]
    public class PasswordPolicyTests
    {
        // AUTH_007 - Kiểm tra độ mạnh mật khẩu
        [Test]
        public void AUTH_007_Password_TooShort_ShouldBeInvalid()
        {
            // Arrange
            string shortPassword = "abc12";

            // Act
            bool isValid = IsValidPassword(shortPassword);

            // Assert
            Assert.That(isValid, Is.False);
        }

        [Test]
        public void AUTH_007_Password_NoSpecialChar_ShouldBeInvalid()
        {
            // Arrange
            string noSpecialCharPassword = "Abc12345";

            // Act
            bool isValid = IsValidPassword(noSpecialCharPassword);

            // Assert
            Assert.That(isValid, Is.False);
        }

        [Test]
        public void AUTH_007_Password_Valid_ShouldPass()
        {
            // Arrange
            string validPassword = "Abc@12345";

            // Act
            bool isValid = IsValidPassword(validPassword);

            // Assert
            Assert.That(isValid, Is.True);
        }

        private bool IsValidPassword(string password)
        {
            // Logic kiểm tra password policy
            return password.Length >= 8 &&
                   password.Any(char.IsUpper) &&
                   password.Any(char.IsLower) &&
                   password.Any(char.IsDigit) &&
                   password.Any(ch => !char.IsLetterOrDigit(ch));
        }
    }
}