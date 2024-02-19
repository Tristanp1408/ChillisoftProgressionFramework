namespace Interfaces
{
    public class Program
    {
        static void Main(string[] args)
        {
            var circle = new Circle(5);
            var rectangle = new Rectangle(4, 6);

            var calculator = new ShapeCalculator();

            var circleArea = calculator.CalculateArea(circle);
            var rectangleArea = calculator.CalculateArea(rectangle);

            Console.WriteLine("Area of Circle: " + circleArea);
            Console.WriteLine("Area of Rectangle: " + rectangleArea);
        }
    }
}
