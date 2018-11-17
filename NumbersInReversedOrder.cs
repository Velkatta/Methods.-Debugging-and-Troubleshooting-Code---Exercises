using System;

namespace _04._Numbers_in_Reversed_Order
{
    class NumbersInReversedOrder
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            string reversed = ReversedNumber(number);
            Console.WriteLine(reversed);
        }

        private static string ReversedNumber(string number)
        {
            string reversed = "";
            for (int i = number.Length - 1; i >= 0; i--)
            {
                reversed += number[i];
            }
            return reversed;
        }
    }
}