namespace PrimeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please enter a prime number (or 'x' to exit):");
                var input = Console.ReadLine();

                if (input == "x")
                {
                    break;
                }

                if (int.TryParse(input, out var number))
                {
                    PrimeNumberCheck(number);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
            }

        }

        public static void PrimeNumberCheck(int number)
        {
            var flag = true;

            if (number == 1)
            {
                Console.WriteLine("number is not prime");
            }
            else if (number > 1)
            {
                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        flag = false;
                        break;
                    }
                }
            }

            Console.WriteLine(flag ? "number is prime" : "number is not prime");
        }
    }
}
