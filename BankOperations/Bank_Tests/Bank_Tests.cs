using bank_kata;
using System;
using System.IO;
using Xunit;
using System.Linq;

namespace Bank_Tests
{
    public class Bank_Tests : IDisposable
    {
        private IManageAccount _accountManager;
        private readonly string _accountName;

        public Bank_Tests()
        {
            _accountName = "1234";
            _accountManager = new AccountManager(_accountName);
        }

        public void Dispose()
        {
            _accountManager.ResetAccount();
        }

        [Fact]
        public void Should_Test_Balance()
        {
            var balance = _accountManager.Balance;
            Assert.Equal(0, balance);
        }

        [Fact]
        public void Should_Test_Deposit()
        {
            var amount = 40.50;
            _accountManager.Deposit(amount);

            Assert.Equal(amount, _accountManager.Balance);
        }

        [Fact]
        public void Should_Test_Negative_Deposit()
        {
            var amount = -40.99;
            Assert.Throws<ArgumentOutOfRangeException>(() => _accountManager.Deposit(amount));
        }

        [Fact]
        public void Should_Test_Withdraw()
        {
            var amount = 44.50;
            _accountManager.Deposit(100);
            _accountManager.Withdraw(amount);

            Assert.Equal(55.50, _accountManager.Balance);
        }

        [Fact]
        public void Should_Test_Withdraw_NegativeAmount()
        {
            var amount = -50;

            Assert.Throws<ArgumentOutOfRangeException>(() => _accountManager.Withdraw(amount));
            Assert.Equal(0, _accountManager.Balance);
        }

        [Fact]
        public void Should_Test_Withdraw_TooMuch()
        {
            var amount = 145.99;
            _accountManager.Deposit(100);

            Assert.Throws<ArgumentOutOfRangeException>(() => _accountManager.Withdraw(amount));
            Assert.Equal(100, _accountManager.Balance);
        }

        [Fact]
        public void Should_Display_Operations()
        {
            _accountManager.Deposit(100);
            _accountManager.Withdraw(55.50);

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                _accountManager.DisplayOperations();
                Assert.True(sw.ToString().Split("\r\n",StringSplitOptions.RemoveEmptyEntries).Count() == 2);
            }

            Assert.Equal(44.50, _accountManager.Balance);
            Assert.True(_accountManager.Operations.Count == 2);
        }
    }
}