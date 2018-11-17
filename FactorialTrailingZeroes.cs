using System;
using System.Numerics;

namespace _14_Fatorial_Trailing_Zeroes
{
    class FactorialTrailingZeroes
    {
        static void Main(string[] args)
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());

            BigInteger factorial = FindFactorial(n);
            BigInteger zeroes = FindZeroes(factorial);
            //Console.WriteLine(factorial);
            Console.WriteLine(zeroes);

        }

        private static BigInteger FindZeroes(BigInteger factorial)
        {
            int count = 0;
            while (factorial != 0)
            {
                BigInteger digit = factorial % 10;
                if (digit == 0)
                {
                    count++;
                }
                else
                {
                    break;
                }
                factorial /= 10;
            }
            return count;
        }

        private static BigInteger FindFactorial(BigInteger n)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
