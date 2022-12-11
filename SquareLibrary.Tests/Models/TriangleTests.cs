namespace SquareLibrary.Tests.Models;
public class TriangleTests
{
    [Theory]
    [InlineData(18, 4, 5, "Sum of any two sides of a triangle must be greater than third side.")]
    [InlineData(3, 18, 5, "Sum of any two sides of a triangle must be greater than third side.")]
    [InlineData(3, 4, 18, "Sum of any two sides of a triangle must be greater than third side.")]
    [InlineData(3, 4, 7, "Sum of any two sides of a triangle must be greater than third side.")]
    [InlineData(-3, 4, 5, "Triangle side cannot be less or equal 0. Provided value: -3.")]
    [InlineData(3, -4, 5, "Triangle side cannot be less or equal 0. Provided value: -4.")]
    [InlineData(3, 4, -5, "Triangle side cannot be less or equal 0. Provided value: -5.")]
    [InlineData(0, 4, 5, "Triangle side cannot be less or equal 0. Provided value: 0.")]
    [InlineData(3, 0, 5, "Triangle side cannot be less or equal 0. Provided value: 0.")]
    [InlineData(3, 4, 0, "Triangle side cannot be less or equal 0. Provided value: 0.")]
    public void CreateTriangle_GetInvalidArguments_ThrowsArgumentException(double a, double b, double c, string expected)
    {
        Action act = () => new Triangle(a, b, c);
        ArgumentException exception = Assert.Throws<ArgumentException>(act);

        Assert.Equal(expected, exception.Message);
    }
}
