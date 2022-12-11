namespace SquareLibrary.Tests.Models;
public class CircleTests
{
    [Theory]
    [InlineData(0)]
    [InlineData(-5)]
    public void CreateCircle_GetInvalidArgument_ThrowsArgumentException(double radius)
    {
        Action act = () => new Circle(radius);
        ArgumentException exception = Assert.Throws<ArgumentException>(act);

        Assert.Equal($"Radius cannot be less or equal 0. Provided value: {radius}.", exception.Message);
    }
}
