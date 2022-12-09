using SquareLibrary.Models.Abstractions;

namespace SquareLibrary.Models;

public class Circle : BaseFigure
{
    private double radius { get; }

    public Circle(double radius)
    {
        if (radius <= 0)
            throw new ArgumentException($"Radius cannot be less or equal 0. Provided value: {radius}");

        this.radius = radius;
    }

    internal override double CalculateSquare() => Math.PI * Math.Pow(radius, 2);
}
