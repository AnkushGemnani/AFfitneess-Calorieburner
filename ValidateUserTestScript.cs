using System;
using NUnit.Framework;

namespace AGFitness.Test
{
    [TestFixture]
    internal class ValidateUserTestScript
    {
        private ValidateUser validateUser;

        [SetUp]
        public void Setup()
        {
            validateUser = new ValidateUser();
        }

        [Test]
        public void ValidateUser_ValidUsernameAndPassword_ReturnsSuccess()
        {
            // Arrange
            string username = "ankushh";
            string password = "Killersking@27";

            // Act
            int result = validateUser.validateuser(username, password);

            // Assert
            Assert.AreEqual(1, result); // Assuming 1 means successful login
        }

        [Test]
        public void ValidateUser_IncorrectPassword_ReturnsFailure()
        {
            // Arrange
            string username = "ankushh";
            string incorrectPassword = "wrongpassword";

            // Act
            int result = validateUser.validateuser(username, incorrectPassword);

            // Assert
            Assert.AreNotEqual(1, result); // Ensure login failure for incorrect password
        }

        [Test]
        public void ValidateUser_InvalidUsername_ReturnsUsernameNotFound()
        {
            // Arrange
            string invalidUsername = "invaliduser";
            string password = "somepassword";

            // Act
            int result = validateUser.validateuser(invalidUsername, password);

            // Assert
            Assert.AreEqual(2, result); // Assuming 2 means username not found
        }
    }
}
