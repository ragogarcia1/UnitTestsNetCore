using Xunit;

namespace LibraryRago
{
    public class ClientXUnitTest
    {
        [Fact]
        public void CreateName_ReturnComplete()
        {
            Client cliente = new();

            string result = cliente.NameComplete("Oscar", "García");

            Assert.That(result, Is.EqualTo("Oscar García"));
        }
    }
}
