using Shapes.Strategies;

namespace Shapes.Shapes;

public class Triangle(IShapeAreaStrategy shapeAreaStrategy, double sideA, double sideB) : IShape
{
    public string Name { get; set; } = "Triangle";
    public double SideA { get; set; } = sideA;
    public double SideB { get; set; } = sideB;

    public double CalculateArea()
    {
        return shapeAreaStrategy.CalculateArea(this);
    }
}