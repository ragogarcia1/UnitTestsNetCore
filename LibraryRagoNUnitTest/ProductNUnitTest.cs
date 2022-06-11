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
    }
}
