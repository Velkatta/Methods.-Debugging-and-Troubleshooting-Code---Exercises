using System;

namespace _11._Geometry_Calculator
{
    class GeometryCalculator
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            if (type == "triangle")
            {
                FindAreaTriangle();
            }
            else if (type == "square")
            {
                FindAreaSquare();
            }
            else if (type == "rectangle")
            {
                FindAreaRectangle();
            }
            else if (type == "circle")
            {
                FindAreaCircle();
            }
        }

        private static void FindAreaCircle()
        {
            double radius = double.Parse(Console.ReadLine());

            double area = Math.PI * radius * radius;
            Console.WriteLine($"{area:f2}");
            return;
        }

        private static void FindAreaRectangle()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double area = width * height;
            Console.WriteLine($"{area:f2}");
            return;

        }

        private static void FindAreaSquare()
        {
            double side = double.Parse(Console.ReadLine());
            double area = side * side;
            Console.WriteLine($"{area:f2}");
            return;
        }

        private static void FindAreaTriangle()
        {
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double area = side * height / 2;
            Console.WriteLine($"{area:f2}");
            return;
        }
    }
}
