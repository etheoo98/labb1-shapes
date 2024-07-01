using Shapes;
using Shapes.Factories;
using Shapes.Shapes;

/*
 A very simple application that implements design patterns to calculate
 and output the area of shapes.
 
 Design patterns used:
 - Factory Method
 - Singleton
 - Strategy 
 */

var shapeFactory = new ShapeFactory();
var shapes = new List<IShape>
{
    shapeFactory.CreateTriangle(10, 10),
    shapeFactory.CreateSquare(10),
    shapeFactory.CreateRectangle(10, 15),
    shapeFactory.CreateParallelogram(10, 20)
};

Console.Clear();
var logger = Logger.Instance;

foreach (var shape in shapes)
{
    var area = shape.CalculateArea();
    logger.Log($"{shape.Name} Area: {Math.Round(area, 1)} units");
}