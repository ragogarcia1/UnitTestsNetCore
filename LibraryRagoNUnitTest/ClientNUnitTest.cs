
using NUnit.Framework;

namespace LibraryRago
{
    [TestFixture]
    public class ClientNUnitTest
    {
        [Test]
        public void CreateName_ReturnComplete()
        {
            Client cliente = new();

            string result = cliente.NameComplete("Oscar", "García");

            Assert.That(result, Is.EqualTo("Oscar García"));
        }
    }
}
