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
    public class ProductNUnitTest
    {
        [Test]
        public void GetPrice_ClientPremium_ReturnDiscount()
        {
            Product product = new()
            {
                Price = 50
            };

            var response = product.GetPrice(new Client { isPremium = true });

            Assert.That(response, Is.EqualTo(40));
        }

        [Test]
        public void GetPrice_ClientPremiumMoq_ReturnPrice()
        {
            Product product = new()
            {
                Price = 50
            };
            var cliente = new Mock<IClient>();
            cliente.Setup(item => item.isPremium).Returns(true);

            var response = product.GetPrice(cliente.Object);

            Assert.That(response, Is.EqualTo(40));
        }
    }
}
