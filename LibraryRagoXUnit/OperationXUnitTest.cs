using Xunit;

namespace LibraryRago
{
    public class OperationXUnitTest
    {
        [Fact]
        //[TestCase(50,10, ExpectedResult = 60)]
        public int SumNums_InputTwoNumbers_GetCorrectValue(int num1Test, int num2Test)
        {
            Operation op = new();
            return op.sumNums(num1Test, num2Test);
        }

        [Fact]

        public void NumberIsPair_True()
        {
            Operation op = new();
            int number = 22;
            bool result = op.isPair(number);

            Assert.True(result);
        }

        [Theory]
        //[InlineData(2.2, 2.4, ExpectedResult = 4.6)]
        //[InlineData(2.23, 1.24, ExpectedResult = 3.47)]
        //[TestCase(2.2, 2.4)]
        [InlineData(2.23, 1.24)]
        public void SumDecimal_InputNumber_CorrectValue(double num1, double num2)
        {
            Operation op = new();
            double result = op.sumDecimal(num1, num2);
            Assert.AreEqual(3.4, result, 0.1);
        }
    }
}
