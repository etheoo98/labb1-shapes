using Shapes.Shapes;

namespace Shapes.Strategies;

/// <summary>
/// Represents a strategy for calculating the area of a square shape using Strategy design pattern.
/// </summary>
public class SquareAreaStrategy : IShapeAreaStrategy
{
    public double CalculateArea(IShape shape)
    {
        if (shape is not Square square)
        {
            throw new ArgumentException("Shape is not a square");
        }
        
        return Math.Pow(square.Side, 2);
    }
}