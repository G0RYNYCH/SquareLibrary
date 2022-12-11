namespace SquareLibrary.Services;

public class SquareCalculator : ISquareCalculator
{
    public double Calculate(FigureBase figure) => figure.CalculateSquare();
}
