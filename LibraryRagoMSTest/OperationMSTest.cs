using LibraryRago;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibraryRagoMSTest
{
    [TestClass]
    public class OperationMSTest
    {
        [TestMethod]
        public void sumNums_InputTwoNumbers_GetCorrectValue()
        {
            // 1. Arrange
            //Acá se inicializan las variables para ejecutar el test.
            Operation op = new();
            int num1Test = 50;
            int num2Test = 19;

            // 2. Act
            int result = op.sumNums(num1Test, num2Test);

            //Assert
            Assert.AreEqual(69, result);
        }

        [TestMethod]
        public void sumNums_InputTwoNumbers_GetIncorrectValue()
        {
            // 1. Arrange
            //Acá se inicializan las variables para ejecutar el test.
            Operation op = new();
            int num1Test = 50;
            int num2Test = 19;

            // 2. Act
            int result = op.sumNums(num1Test, num2Test);

            //Assert
            Assert.AreNotEqual(67, result);
        }
    }
}
