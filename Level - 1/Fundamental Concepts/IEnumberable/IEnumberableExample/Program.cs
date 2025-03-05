namespace IEnumberableExample
{
    internal class Program
    {
        private static readonly IEnumerable<int> _numbers = new List<int> { 1, 2, 3, 4, 5 };

        static void Main(string[] args)
        {
            // SimpleIEnumberable();

            //foreach (var num in YieldReturningIEnumerable())
            //{
            //    Console.WriteLine($"Yield returning: {num}");
            //}

            //IEnumerableWithLinq();
        }

        private static void IEnumerableWithLinq()
        {
            Console.WriteLine("IEnumerable with Linq Example... \n");

            var filtered = _numbers.Where(n => n > 3);

            foreach (var num in filtered)
            {
                Console.WriteLine(num);
            }
        }

        private static void SimpleIEnumberable()
        {
            Console.WriteLine("Simple IEnumerable Example... \n");
            var numbers = new List<int> { 1, 2, 3, 4, 5 };

            foreach (var num in _numbers)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("\n");
        }

        private static IEnumerable<string> YieldReturningIEnumerable()
        {
            foreach (var num in _numbers)
            {
                yield return $"{num}";
            }
        }
    }
}
