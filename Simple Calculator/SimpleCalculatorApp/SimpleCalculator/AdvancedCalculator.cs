using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class AdvancedCalculator : SimpleCalculator, ICalculator, IAdvancedCalculator
    {
        public double Square(double number)
        {
            throw new NotImplementedException();
        }

        public double CalculateRectangleArea(double width, double height)
        {
            throw new NotImplementedException();
        }

        public double CalculateTriangleArea(double triangleBase, double height)
        {
            throw new NotImplementedException();
        }
        public double CalculateCircleArea(double radius)
        {
            throw new NotImplementedException();
        }
    }
}
