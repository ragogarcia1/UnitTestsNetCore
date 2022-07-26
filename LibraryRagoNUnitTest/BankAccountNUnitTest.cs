using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryRago
{
    [TestFixture]
    public class BankAccountNUnitTest
    {
        private BankAccount account;
        [SetUp]
        public void SetUp()
        {
            
        }

        [Test]
        public void Desposit_Input100LoggerFake_True()
        {
            BankAccount bankAccount = new BankAccount(new LoggerFake());

            var result = bankAccount.Deposit(100);

            Assert.IsTrue(result);
            Assert.That(bankAccount.GetBalance(), Is.EqualTo(100));
        }

        [Test]
        public void Desposit_Input100Mocking_True()
        {
            var mocking = new Mock<ILoggerGeneral>();
            BankAccount bankAccount = new BankAccount(mocking.Object);

            var result = bankAccount.Deposit(100);
            
            Assert.IsTrue(result);
            Assert.That(bankAccount.GetBalance(), Is.EqualTo(100));
        }

        [Test]
        [TestCase(200,100)]
        [TestCase(200,150)]
        public void Withdrawal_100withBalance200_ReturnsTrue(int balance, int withdrawal)
        {
            var loggerMock = new Mock<ILoggerGeneral>();
            
            loggerMock.Setup(mock => mock.LogDataBase(It.IsAny<string>())).Returns(true);
            loggerMock.Setup(mock => mock.LogBalanceLaterWithdrawal(It.Is<int>(number => number > 0))).Returns(true);

            BankAccount accountBank = new(loggerMock.Object);

            accountBank.Deposit(balance);
            var result = accountBank.Withdrawal(withdrawal);

            Assert.IsTrue(result);
        }
    }
}
