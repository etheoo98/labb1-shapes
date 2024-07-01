using Shapes.Strategies;

namespace Shapes.Shapes;

public class Square(IShapeAreaStrategy shapeAreaStrategy, double side) : IShape
{
    public string Name { get; set; } = "Square";
    public double Side { get; set; } = side;


    public double CalculateArea()
    {
        return shapeAreaStrategy.CalculateArea(this);
    }
}