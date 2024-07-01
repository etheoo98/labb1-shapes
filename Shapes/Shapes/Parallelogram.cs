using Shapes.Strategies;

namespace Shapes.Shapes;

public class Parallelogram(IShapeAreaStrategy shapeAreaStrategy, double width, double height)
    : Rectangle(shapeAreaStrategy, width, height, "Parallelogram");