using Calculator;

namespace SimpleCalculatorTests
{
    public class SimpleCalculatorUnitTests
    {
        [Theory]
        [InlineData(1,1,2)]
        [InlineData(50,25,75)]
        [InlineData(200,75,275)]
        [InlineData(-3,40,37)]
        public void GivenTwoValidNumbers_Calculator_AddsThem(int num1, int num2, int expectedResult) 
        {
            ICalculator calc = new SimpleCalculator();

            int result = calc.Add(num1, num2);

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(1, 1, 0)]
        [InlineData(50, 25, 25)]
        [InlineData(200, 75, 125)]
        [InlineData(-3, 40, -43)]
        public void GivenTwoValidNumbers_Calculator_SubtractsThem(int num1, int num2, int expectedResult)
        {
            ICalculator calc = new SimpleCalculator();

            int result = calc.Subtract(num1, num2);

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(50, 2, 100)]
        [InlineData(200, 10, 2000)]
        [InlineData(-3, 40, -120)]
        public void GivenTwoValidNumbers_Calculator_MultipliesThem(int num1, int num2, int expectedResult)
        {
            ICalculator calc = new SimpleCalculator();

            int result = calc.Multiply(num1, num2);

            Assert.Equal(expectedResult, result);
        }


        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(50, 25, 2)]
        [InlineData(1, 3, 0.33333333333333331)]
        [InlineData(10, 7, 1.4285714285714286)]
        public void GivenTwoValidNumbers_Calculator_DividesThem(int num1, int num2, double expectedResult)
        {
            ICalculator calc = new SimpleCalculator();

            double result = calc.Divide(num1, num2);

            Assert.Equal(expectedResult, result);
        }
    }
}