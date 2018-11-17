using System;

namespace _01._Hello__Name_
{
    class HelloName
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            PrintNme(name);
        }

        private static void PrintNme(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}