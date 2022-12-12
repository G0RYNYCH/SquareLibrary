namespace SquareLibrary.Tests.Models;

public class TriangleTests
{
    const string sumMmessage = "Sum of any two sides of a triangle must be greater than third side.";
    const string sideMmessage = "Triangle side cannot be less or equal 0. Provided value: 0.";

    [Theory]
    [InlineData(18, 4, 5, sumMmessage)]
    [InlineData(3, 18, 5, sumMmessage)]
    [InlineData(3, 4, 18, sumMmessage)]
    [InlineData(3, 4, 7, sumMmessage)]
    [InlineData(-3, 4, 5, "Triangle side cannot be less or equal 0. Provided value: -3.")]
    [InlineData(3, -4, 5, "Triangle side cannot be less or equal 0. Provided value: -4.")]
    [InlineData(3, 4, -5, "Triangle side cannot be less or equal 0. Provided value: -5.")]
    [InlineData(0, 4, 5, sideMmessage)]
    [InlineData(3, 0, 5, sideMmessage)]
    [InlineData(3, 4, 0, sideMmessage)]
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
