namespace Sieve_of_Eratosthenes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = 1000;
            Console.WriteLine("Prime numbers smaller than or equal to " + n);

            var primes = FindPrimes(n);

            foreach (var prime in primes)
                Console.Write(prime + " ");
        }

        public static List<int> FindPrimes(int n)
        {
            var prime = new bool[n + 1];

            for (var i = 0; i <= n; i++)
                prime[i] = true;

            for (var p = 2; p * p <= n; p++)
            {
                if (prime[p])
                {
                    for (var i = p * p; i <= n; i += p)
                        prime[i] = false;
                }
            }

            var primes = new List<int>();
            for (var p = 2; p <= n; p++)
            {
                if (prime[p])
                    primes.Add(p);
            }

            return primes;
        }
    }
}