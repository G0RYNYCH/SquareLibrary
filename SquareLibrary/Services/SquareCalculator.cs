namespace SquareLibrary.Services;

public class SquareCalculator : ISquareCalculator
{
    /// <inheritdoc />
    public double Calculate(FigureBase figure) => figure.CalculateSquare();
}
