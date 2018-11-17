using System;

namespace MethodsDemoExer
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            string output = Console.ReadLine();
            double result = 0.0;
            switch (output)
            {
                case "face":
                    result = GetFace(n);
                    break;
                case "space":
                    result = GetSpace(n);
                    break;
                case "volume":
                    result = GetVolume(n);
                    break;
                case "area":
                    result = GetArea(n);
                    break;
                default:
                    break;
            }
            Console.WriteLine($"{result:f2}");

        }

        static double GetArea(double n)
        {
            double result = 6 * n * n;
            return result;
        }

        static double GetVolume(double n)
        {
            double result = n * n * n;
            return result;
        }

        static double GetSpace(double n)
        {
            double result = Math.Sqrt(3 * n * n);
            return result;
        }

        static double GetFace(double n)
        {
            double result = Math.Sqrt(2* n*n);
            return result;
        }
    }
}