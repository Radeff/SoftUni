using System;

namespace _04.NumbersInReversedOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputNumber = Console.ReadLine();
            Console.WriteLine(DecimalNumberReverse(inputNumber));
        }
        public static decimal DecimalNumberReverse(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            var result = new string(charArray);
            return decimal.Parse(result);
        }
    }
}
