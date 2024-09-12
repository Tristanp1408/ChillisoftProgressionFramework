namespace Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();

            // Instantiate delegates
            var add = new Calculator.MathOperation(calculator.Add);
            var subtract = new Calculator.MathOperation(calculator.Subtract);

            // Use the delegate
            Console.WriteLine("Addition: " + calculator.ExecuteOperation(add, 10, 5));
            Console.WriteLine("Subtraction: " + calculator.ExecuteOperation(subtract, 10, 5));
        }
    }
}
