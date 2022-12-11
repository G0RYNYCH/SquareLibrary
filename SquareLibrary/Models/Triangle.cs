namespace SquareLibrary.Models;

public class Triangle : FigureBase
{
    private double A { get; }
    private double B { get; }
    private double C { get; }
    
    public Triangle(double a, double b, double c)
    {
        var validationException = ValidateConstructorParams(a, b, c);

        if (validationException != null)
            throw validationException;

        A = a;
        B = b;
        C = c;
    }

    internal override double CalculateSquare()
    {
        var perimeter = CalculatePerimeter();
        var halfPerimeter = perimeter / 2;

        return Math.Sqrt(halfPerimeter * (halfPerimeter - A) * (halfPerimeter - B) * (halfPerimeter - C));
    }

    private double CalculatePerimeter() => A + B + C;

    private Exception? ValidateConstructorParams(double a, double b, double c)
    {
        var sidesLenthEcxeption = ValidateSidesLength(a, b, c);

        if (sidesLenthEcxeption != null)
            return sidesLenthEcxeption;

        return ValidateInequality(a, b, c);
    }
    
    private Exception? ValidateSidesLength(double a, double b, double c)
    {
        var maxExceptionCount = 4;
        var exceptions = new List<Exception>(maxExceptionCount);

        Span<double> sides = stackalloc[] { a, b, c };

        foreach (var side in sides)
        {
            var exception = ValidateSideLength(side);

            if (exception != null)
                exceptions.Add(exception);
        }

        if (exceptions.Count == 0)
            return null;

        return exceptions.Count == 1 ? exceptions.First() : new AggregateException(exceptions);
    }

    private Exception? ValidateSideLength(double side)
    {
        if (side <= 0)
            return new AggregateException($"Triangle side cannot be less or equal 0. Provided value: {side}");

        return null;
    }

    private Exception? ValidateInequality(double a, double b, double c)
    {
        var sidesSumValid = a + b > c && a + c > b && b + c > a;

        if (!sidesSumValid)
        {
            var exceptionMessage = "Sum of any two sides of a triangle must be greater than third side.";

            return new ArgumentException(exceptionMessage);
        }

        return null;
    }
}
