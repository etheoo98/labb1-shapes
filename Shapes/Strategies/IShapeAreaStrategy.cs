using Shapes.Shapes;

namespace Shapes.Strategies;

public interface IShapeAreaStrategy
{
    public double CalculateArea(IShape shape);
}