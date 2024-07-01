using Shapes.Shapes;

namespace Shapes.Strategies;

/// <summary>
/// Represents the strategy for calculating the area of a rectangle shape using Strategy design pattern.
/// </summary>
public class RectangleAreaStrategy : IShapeAreaStrategy
{
    public double CalculateArea(IShape shape)
    {
        if (shape is not Rectangle rectangle)
        {
            throw new ArgumentException("Shape is not a rectangle nor a parallelogram");
        }
        
        return rectangle.Width * rectangle.Height;
    }
}