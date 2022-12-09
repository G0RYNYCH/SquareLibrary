namespace SquareLibrary.Services;
public class SquareCalclator : ISquareCalculator
{
    public double Calculate(FigureBase figure) => figure.CalculateSquare();
}
