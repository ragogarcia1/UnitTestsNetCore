using Moq;

namespace LibraryRago
{
    [TestFixture]
    public class BankAccountXUnitTest
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
    }
}
