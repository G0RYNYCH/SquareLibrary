namespace SquareLibrary.Models;

public class Circle : FigureBase
{
    private double Radius { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Circle"/> class.
    /// </summary>
    /// <param name="radius">radius.</param>
    /// <exception cref="System.ArgumentException">Radius cannot be less or equal 0. Provided value: {radius}</exception>
    public Circle(double radius)
    {
        if (radius <= 0)
            throw new ArgumentException($"Radius cannot be less or equal 0. Provided value: {radius}.");

        Radius = radius;
    }

    internal override double CalculateSquare() => Math.PI * Math.Pow(Radius, 2);
}
