using Shapes.Shapes;
using Shapes.Strategies;

namespace Shapes.Factories;

/// <summary>
/// Represents a shape factory that uses the Factory Method design pattern to create shape objects.
/// An appropriate IAreaStrategy is injected into each constructor, as to follow Dependency Inversion Principle.
/// </summary>
public class ShapeFactory : IShapeFactory
{
    public IShape CreateTriangle(double sideA, double sideB)
    {
        return new Triangle(new TriangleAreaStrategy(), sideA, sideB);
    }

    public IShape CreateSquare(double side)
    {
        return new Square(new SquareAreaStrategy(), side);
    }

    public IShape CreateRectangle(double width, double height)
    {
        return new Rectangle(new RectangleAreaStrategy(), width, height);
    }

    public IShape CreateParallelogram(double width, double height)
    {
        return new Parallelogram(new RectangleAreaStrategy(), width, height);
    }
}