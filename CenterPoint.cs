using System;

namespace _08._Center_Point
{
    class CenterPoint
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            string result = FindClosesPoint(x1, x2, y1, y2);
            if (result == "first")
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }

        private static string FindClosesPoint(double x1, double x2, double y1, double y2)
        {
            double diagonal1 = Math.Sqrt(x1 * x1 + y1 * y1);
            double diagonal2 = Math.Sqrt(x2 * x2 + y2 * y2);
            if (diagonal1 <= diagonal2)
            {
                return "first";
            }
            else
            {
                return "second";
            }
        }
    }
}