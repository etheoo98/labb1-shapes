using Shapes.Strategies;

namespace Shapes.Shapes;

public class Rectangle(IShapeAreaStrategy shapeAreaStrategy, double width, double height, string name = "Rectangle")
    : IShape
{
    public string Name { get; set; } = name;
    public double Width { get; } = width;
    public double Height { get; } = height;
    
    public double CalculateArea()
    {
        return shapeAreaStrategy.CalculateArea(this);
    }
}