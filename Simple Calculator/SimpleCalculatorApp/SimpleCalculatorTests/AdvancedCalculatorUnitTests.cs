using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculatorTests
{
    public class AdvancedCalculatorUnitTests
    {
        [Theory]
        [InlineData(1, 1)]
        [InlineData(2.5, 6.25)]
        [InlineData(3.443, 11.85)]
        public void GivenTwoValidNumbers_Calculator_ReturnsTheSquareOfTheNumber(double number, double expectedResult)
        {
            IAdvancedCalculator calculator = new AdvancedCalculator();
            double result = calculator.Square(number);

            Assert.Equal(expectedResult, result);
        }


        [Theory]
        [InlineData(1, 5, 5)]
        [InlineData(5, 5, 25)]
        [InlineData(1.25, 4.75, 5.93)]
        public void GivenTwoValidNumbers_Calculator_ReturnsTheAreaOfARectangle(double width, double height, double expectedResult)
        {
            IAdvancedCalculator calculator = new AdvancedCalculator();
            double result = calculator.CalculateRectangleArea(width, height);

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(1, 5, 2.5)]
        [InlineData(5, 5, 12.5)]
        [InlineData(2, 5.67, 5.67)]
        public void GivenTwoValidNumbers_Calculator_ReturnsTheAreaOfATriangle(double triangleBase, double height, double expectedResult)
        {
            IAdvancedCalculator calculator = new AdvancedCalculator();
            double result = calculator.CalculateTriangleArea(triangleBase, height);

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(1, 3.14)]
        [InlineData(2.5, 19.63)]
        [InlineData(3.443, 37.24)]
        public void GivenTwoValidNumbers_Calculator_ReturnsTheAreaOfACircle(double radius, double expectedResult)
        {
            IAdvancedCalculator calculator = new AdvancedCalculator();
            double result = calculator.CalculateCircleArea(radius);

            Assert.Equal(expectedResult, result);
        }
    }
}
