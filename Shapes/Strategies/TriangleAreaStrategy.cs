using Shapes.Shapes;

namespace Shapes.Strategies;

/// <summary>
/// Represents a strategy for calculating the area of a triangle using Strategy design pattern.
/// </summary>
public class TriangleAreaStrategy : IShapeAreaStrategy
{
    public double CalculateArea(IShape shape)
    {
        if (shape is not Triangle triangle)
        {
            throw new ArgumentException("Shape is not a triangle");
        }
        
        return 0.5 * triangle.SideA * triangle.SideB;
    }
}