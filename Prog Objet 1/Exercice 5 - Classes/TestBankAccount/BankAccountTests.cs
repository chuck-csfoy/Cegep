using Exercice_5___Classes;

namespace TestBankAccount
{
    public class BankAccountTests
    {
        [Fact]
        public void Constructor_ClientNameIsEmpty_ShouldThrowException()
        {
            Assert.Throws<ArgumentException>(() => new BankAccount("", 1000f, 0f));
        }

        [Fact]
        public void Constructor_ValidParameterValuesShouldInitializePropertiesCorrectly_ExpectedValues()
        {
            // Arrange & Act
            BankAccount account = new BankAccount("Johnny Cash", 100000f, 0f);

            // Assert
            Assert.Equal("Johnny Cash", account.ClientName);
            Assert.Equal(100000f, account.Balance);
            Assert.Equal(0f, account.LineOfCredit);
        }

        [Fact]
        public void Deposit_ValidAmountToDeposit_ShouldIncreaseBalance()
        {
            // Arrange
            BankAccount account = new BankAccount("Johnny Cash", 2500500f, 0f);

            // Act
            account.Deposit(200f);

            // Assert
            Assert.Equal(2500700f, account.Balance);
        }

        [Fact]
        public void Deposit_ValidAmountToDepositWithLineOfCredit_ShouldReduceLineOfCreditBeforeIncreasingBalance()
        {
            // Arrange
            BankAccount account = new BankAccount("Johnny Cash", 0f, 100f);

            // Act
            account.Deposit(200f);

            // Assert
            Assert.Equal(100f, account.Balance); 
            Assert.Equal(0f, account.LineOfCredit);
        }

        public void Deposit_AmountToDepositIsNegative_ShouldThrowException()
        {
            // Arrange
            BankAccount account = new BankAccount("Johnny Cash", 1000f, 500f);

            // Act & Assert
            Assert.Throws<ArgumentException>(() => account.Deposit(-100f));
        }

        [Fact]
        public void Withdraw_ValidAmountToWithdraw_ShouldDecreaseBalance()
        {
            // Arrange
            BankAccount account = new BankAccount("Johnny Cash", 1000f, 0f);

            // Act
            account.Withdraw(200f);

            // Assert
            Assert.Equal(800f, account.Balance);
        }

        [Fact]
        public void Withdraw_ValidAmountToWithdrawAndBalanceIsZero_ShouldUseLineOfCredit()
        {
            // Arrange
            BankAccount account = new BankAccount("Johnny Cash", 0f, 500f);

            // Act
            account.Withdraw(200f);

            // Assert
            Assert.Equal(700f, account.LineOfCredit);
            Assert.Equal(0f, account.Balance);
        }

        [Fact]
        public void Withdraw_ValidAmountToWithdrawAndBalanceIsLower_ShouldUseBalanceBeforeLineOfCredit()
        {
            // Arrange
            BankAccount account = new BankAccount("Johnny Cash", 0f, 500f);

            // Act
            account.Withdraw(200f);

            // Assert
            Assert.Equal(700f, account.LineOfCredit);
            Assert.Equal(0f, account.Balance);
        }

        [Fact]
        public void Withdraw_ValidAmountToWithdrawAndBalanceIsZeroAndLineOfCreditIsNotSufficient_ShouldThrowException_WhenOverLimit()
        {
            // Arrange
            BankAccount account = new BankAccount("Johnny Cash", 0f, 5000f);

            // Act & Assert
            Assert.Throws<ArgumentException>(() => account.Withdraw(600f));
        }

        [Fact]
        public void Withdraw_AmountToWithdrawIsNegative_ShouldThrowException()
        {
            // Arrange
            BankAccount account = new BankAccount("Johnny Cash", 1000f, 0f);

            // Act & Assert
            Assert.Throws<ArgumentException>(() => account.Withdraw(-100f));
        }
    }
}