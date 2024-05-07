namespace Calculator
{
    public interface IAdvancedCalculator : ICalculator
    {
        double Square(double number);
        double CalculateRectangleArea(double width, double height);
        double CalculateTriangleArea(double triangleBase, double height);
        double CalculateCircleArea(double radius);
    }
}