using System;

namespace _03._English_Name_of_Last_Digit
{
    class EnglishNameOfTheLastDigit
    {
        static void Main(string[] args)
        {
            long number = Math.Abs(long.Parse(Console.ReadLine()));
            string lastDigit = GetName(Math.Abs(number));
            Console.WriteLine(lastDigit);

        }

        private static string GetName(long number)
        {
            string lastDigit = "";
            long current = number % 10;

            switch (current)
            {
                case 0:
                    lastDigit = "zero";
                    break;
                case 1:
                    lastDigit = "one";
                    break;
                case 2:
                    lastDigit = "two";
                    break;
                case 3:
                    lastDigit = "tree";
                    break;
                case 4:
                    lastDigit = "four";
                    break;
                case 5:
                    lastDigit = "five";
                    break;
                case 6:
                    lastDigit = "six";
                    break;
                case 7:
                    lastDigit = "seven";
                    break;
                case 8:
                    lastDigit = "eigth";
                    break;
                case 9:
                    lastDigit = "nine";
                    break;
                default:
                    break;
            }
            return lastDigit;
        }
    }
}