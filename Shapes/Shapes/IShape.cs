namespace Shapes.Shapes;

public interface IShape
{
    public string Name { get; set; }
    public double CalculateArea();
}