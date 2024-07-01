using Shapes.Shapes;

namespace Shapes.Factories;

public interface IShapeFactory
{
    public IShape CreateTriangle(double sideA, double sideB);
    public IShape CreateSquare(double side);
    public IShape CreateRectangle(double width, double height);
    public IShape CreateParallelogram(double width, double height);
}