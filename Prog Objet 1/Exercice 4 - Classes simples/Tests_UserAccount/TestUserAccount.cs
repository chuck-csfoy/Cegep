using Exercice_3___Classes_Simples;

namespace Tests_UserAccount
{
    public class TestUserAccount
    {
        [Fact]
        public void Constructor_ValidInputs_ShouldInitializedAttributesCorrectly()
        {
            // Arrange
            string expectedUserName = "TestUserName";
            string expectedPassword = "TestPassword";
            int expectedDiscriminator = 1234;
            string expectedEmail = "test@test.com";
            bool expectedIsPremium = true;

            // Act
            UserAccount user = new UserAccount(expectedUserName, expectedPassword, expectedDiscriminator, expectedEmail, expectedIsPremium);

            // Assert
            Assert.Equal(expectedUserName, user.UserName);
            Assert.Equal(expectedPassword, user.UserPasswd);
            Assert.Equal(expectedDiscriminator, user.Discriminator);
            Assert.Equal(expectedEmail, user.UserEmail);
            Assert.True(user.IsPremiumUser);

        }
        [Fact]
        public void UserName_SetValidValue_ShouldUpdateProperty()
        {
            // Arrange
            var user = new UserAccount("OldUser", "Pass123", 1, "user@test.com", false);
            string newUserName = "NewUser";

            // Act
            user.UserName = newUserName;

            // Assert
            Assert.Equal(newUserName, user.UserName);
        }

        [Fact]
        public void UserName_SetEmptyValue_ShouldThrowException()
        {
            // Arrange
            var user = new UserAccount("ValidUser", "Pass123", 1, "user@test.com", false);

            // Act & Assert
            Assert.Throws<ArgumentException>(() => user.UserName = "");
        }

        [Fact]
        public void UserPasswd_SetValidValue_ShouldUpdateProperty()
        {
            // Arrange
            var user = new UserAccount("User", "OldPass", 1, "user@test.com", false);
            string newPassword = "NewPass";

            // Act
            user.UserPasswd = newPassword;

            // Assert
            Assert.Equal(newPassword, user.UserPasswd);
        }

        [Fact]
        public void UserPasswd_SetEmptyValue_ShouldThrowException()
        {
            // Arrange
            var user = new UserAccount("User", "Pass123", 1, "user@test.com", false);

            // Act & Assert
            Assert.Throws<ArgumentException>(() => user.UserPasswd = "");
        }

        [Fact]
        public void Discriminator_SetValidValue_ShouldUpdateProperty()
        {
            // Arrange
            var user = new UserAccount("User", "Pass123", 1, "user@test.com", false);
            int newDiscriminator = 9999;

            // Act
            user.Discriminator = newDiscriminator;

            // Assert
            Assert.Equal(newDiscriminator, user.Discriminator);
        }

        [Fact]
        public void Discriminator_SetNegativeValue_ShouldThrowException()
        {
            // Arrange
            var user = new UserAccount("User", "Pass123", 1, "user@test.com", false);

            // Act & Assert
            Assert.Throws<ArgumentException>(() => user.Discriminator = -1);
        }

        [Fact]
        public void UserEmail_SetValidValue_ShouldUpdateProperty()
        {
            // Arrange
            var user = new UserAccount("User", "Pass123", 1, "olduser@test.com", false);
            string newEmail = "newuser@example.com";

            // Act
            user.UserEmail = newEmail;

            // Assert
            Assert.Equal(newEmail, user.UserEmail);
        }

        [Fact]
        public void UserEmail_SetEmptyValue_ShouldThrowException()
        {
            // Arrange
            var user = new UserAccount("User", "Pass123", 1, "user@test.com", false);

            // Act & Assert
            Assert.Throws<ArgumentException>(() => user.UserEmail = "");
        }

        [Fact]
        public void IsPremiumUser_SetValidValue_ShouldUpdateProperty()
        {
            // Arrange
            var user = new UserAccount("User", "Pass123", 1, "user@test.com", false);

            // Act
            user.IsPremiumUser = true;

            // Assert
            Assert.True(user.IsPremiumUser);
        }


    }
}