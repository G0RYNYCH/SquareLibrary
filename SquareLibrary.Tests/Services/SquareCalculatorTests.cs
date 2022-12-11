namespace SquareLibrary.Tests.Services;

public class SquareCalculatorTests
{
    SquareCalculator squareCalculator = new SquareCalculator();

    [Theory]
    [InlineData(1, Math.PI)]
    [InlineData(2, Math.PI * 4)]
    public void CalculateCircle_GetValidArguments_SquareValue(double radius, double expected)
    {
        var circle = new Circle(radius);
        var result = squareCalculator.Calculate(circle);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(3, 4, 5, 6)]
    [InlineData(5, 5, 6, 12)]
    public void CalculateTriangle_GetValidArguments_SquareValue(double a, double b, double c, double expected)
    {
        var triangle = new Triangle(a, b, c);
        var result = squareCalculator.Calculate(triangle);

        Assert.Equal(expected, result);
    }
}