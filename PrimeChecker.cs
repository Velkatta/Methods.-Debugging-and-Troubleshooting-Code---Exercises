using System;

namespace _06._Prime_Checker
{
    class PrimeChecker
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            bool isPrime = GetPrimeNumber(n);
            Console.WriteLine(isPrime);

        }

        private static bool GetPrimeNumber(long n)
        {
            bool isPrime = true;
            if (n == 0 || n == 1)
            {
                isPrime = false;
            }
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            return isPrime;
        }
    }
}