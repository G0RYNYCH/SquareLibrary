namespace SquareLibrary.Tests.Models;

public class TriangleTests
{
    const string sumMessage = "Sum of any two sides of a triangle must be greater than third side.";
    const string sideMessage = "Triangle side cannot be less or equal 0. Provided value: 0.";

    [Theory]
    [InlineData(18, 4, 5, sumMessage)]
    [InlineData(3, 18, 5, sumMessage)]
    [InlineData(3, 4, 18, sumMessage)]
    [InlineData(3, 4, 7, sumMessage)]
    [InlineData(-3, 4, 5, "Triangle side cannot be less or equal 0. Provided value: -3.")]
    [InlineData(3, -4, 5, "Triangle side cannot be less or equal 0. Provided value: -4.")]
    [InlineData(3, 4, -5, "Triangle side cannot be less or equal 0. Provided value: -5.")]
    [InlineData(0, 4, 5, sideMessage)]
    [InlineData(3, 0, 5, sideMessage)]
    [InlineData(3, 4, 0, sideMessage)]
    public void CreateTriangle_GetInvalidArguments_ThrowsArgumentException(double a, double b, double c, string expected)
    {
        Action act = () => new Triangle(a, b, c);
        ArgumentException exception = Assert.Throws<ArgumentException>(act);

        Assert.Equal(expected, exception.Message);
    }

    [Theory]
    [InlineData(6, 4, 6)]
    [InlineData(7, 11, 15)]
    public void CreateTriangle_GetValidArguments_NoException(double a, double b, double c)
    {
        var exception = Record.Exception(() => new Triangle(a, b, c));

        Assert.Null(exception);
    }
}
