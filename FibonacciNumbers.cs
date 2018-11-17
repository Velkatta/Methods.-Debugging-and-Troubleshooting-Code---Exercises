using System;

namespace _05._Fibonacci_Numbers
{
    class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int result = FindFibonacciNumbers(n);
            Console.WriteLine(result);
        }

        private static int FindFibonacciNumbers(int n)
        {
            int result = 0;
            if (n == 1 || n == 0)
            {
                return 1;
            }
            else
            {
                int before = 1;
                int beforePrevious = 1;
                for (int i = 2; i <= n; i++)
                {
                    result = before + beforePrevious;
                    beforePrevious = before;
                    before = result;
                }
                return result;
            }
        }
    }
}