namespace SquareLibrary.Services.Abstractions;

public interface ISquareCalculator
{
    /// <summary>
    /// Calculates the specified figure.
    /// </summary>
    /// <param name="figure">The figure.</param>
    /// <returns></returns>
    double Calculate(FigureBase figure);
}
