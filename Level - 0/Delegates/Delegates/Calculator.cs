namespace Delegates;

public class Calculator
{
    // Delegate definition
    public delegate int MathOperation(int x, int y);

    // Methods to be used by the delegate
    public int Add(int x, int y) => x + y;
    public int Subtract(int x, int y) => x - y;

    // Method that accepts delegate as a parameter
    public int ExecuteOperation(MathOperation operation, int x, int y)
    {
        return operation(x, y);
    }
}