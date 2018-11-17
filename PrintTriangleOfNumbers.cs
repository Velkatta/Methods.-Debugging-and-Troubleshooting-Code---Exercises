using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintTriangle(n);
        }

        private static void PrintTriangle(int n)
        {
            PrintTopPart(n);
            PrintBottomPart(n);
        }

        private static void PrintBottomPart(int n)
        {
            for (int col = n - 1; col >= 0; col--)
            {
                for (int row = 1; row <=col; row++)
                {
                    Console.Write($"{row} ");
                }
                Console.WriteLine();
            }
        }

        private static void PrintTopPart(int n)
        {
            for (int col = 1; col <= n; col++)
            {
                for (int row = 1; row <= col; row++)
                {
                    Console.Write($"{row} ");
                }
                Console.WriteLine();
            }
        }
    }
}
