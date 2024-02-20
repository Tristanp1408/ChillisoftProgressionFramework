namespace Generics
{
    public class Program
    {
        static void Main(string[] args)
        {
            var intBox = new Box<int>(10);
            Console.WriteLine("Integer value in the box: " + intBox.GetData());
                
            var stringBox = new Box<string>("Hello, Generics!");
            Console.WriteLine("String value in the box: " + stringBox.GetData());

            var boolBox = new Box<bool>(true);
            Console.WriteLine("Boolean value in the box: " + boolBox.GetData());

            var doubleBox = new Box<double>(1.00214);
            Console.WriteLine("Double value in the box: " + doubleBox.GetData());

            var genericList = new List<int>{ 1, 2, 3, 4 };
            genericList.Add(5);

            genericList.Remove(2);

            foreach (var number in genericList)
            {
                Console.WriteLine(number);
            }

        }
    }
}
