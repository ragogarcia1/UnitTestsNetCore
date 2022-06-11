using NUnit.Framework;

namespace LibraryRago
{
    [TestFixture]
    public class OperationNUnitTest
    {
        //[Test]
        //public void sumNums_InputTwoNumbers_GetCorrectValue()
        //{
        //    // 1. Arrange
        //    //Acá se inicializan las variables para ejecutar el test.
        //    Operation op = new();
        //    int num1Test = 50;
        //    int num2Test = 19;

        //    // 2. Act
        //    int result = op.sumNums(num1Test, num2Test);

        //    //Assert
        //    Assert.AreEqual(69, result);
        //}

        [Test]
        [TestCase(50,10, ExpectedResult = 60)]
        public int sumNums_InputTwoNumbers_GetCorrectValue(int num1Test, int num2Test)
        {
            Operation op = new();
            return op.sumNums(num1Test, num2Test);
        }

        [Test]

        public void NumberIsPair_True()
        {
            Operation op = new();
            int number = 22;
            bool result = op.isPair(number);

            Assert.AreEqual(true, result);
        }

        [Test]
        //[TestCase(2.2, 2.4, ExpectedResult = 4.6)]
        //[TestCase(2.23, 1.24, ExpectedResult = 3.47)]
        //[TestCase(2.2, 2.4)]
        [TestCase(2.23, 1.24)]
        public void SumDecimal_InputNumber_CorrectValue(double num1, double num2)
        {
            Operation op = new();
            double result = op.sumDecimal(num1, num2);
            Assert.AreEqual(3.4, result, 0.1);
        }
    }
}
