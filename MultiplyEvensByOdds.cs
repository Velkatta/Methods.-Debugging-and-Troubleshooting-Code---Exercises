using System;

namespace _09._Multiply_Evens_by_Odds
{
    class MultiplyEvensByOdds
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));
            int multi = GetMultipleOfEvenAndOdds(number);
            Console.WriteLine(multi);
        }

        static int GetMultipleOfEvenAndOdds(int number)
        {
            int sumEvenDitits = GetSumOfEvenDigits(number);
            int sumOddsDitits = GetSumOfOddDigits(number);
            int result = sumEvenDitits * sumOddsDitits;
            return result;            
        }

        static int GetSumOfEvenDigits(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int currentDigit = number % 10;
                number /= 10;
                if (currentDigit % 2 == 0)
                {
                    sum += currentDigit;
                }
            }
            return sum;
        }

        static int GetSumOfOddDigits(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int currentDigit = number % 10;
                number /= 10;

                if (currentDigit % 2 == 1)
                {
                    sum += currentDigit;
                }
            }
            return sum;
        }
    }
}