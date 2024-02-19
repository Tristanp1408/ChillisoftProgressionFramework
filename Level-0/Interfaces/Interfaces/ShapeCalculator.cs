namespace Interfaces;

public class ShapeCalculator
{
    public double CalculateArea(IShape shape)
    {
        return shape.CalculateArea();
    }
}