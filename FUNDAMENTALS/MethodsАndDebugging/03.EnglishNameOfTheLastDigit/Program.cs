using System;

namespace _03.EnglishNameOfTheLastDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputNumber = long.Parse(Console.ReadLine());
            Console.WriteLine(DigitInEnglish(inputNumber));
        }

        public static string DigitInEnglish(long input)
        {
            long lastDigit = input % 10;
            var inEnglish = "";
            switch (Math.Abs(lastDigit))
            {
                case 1:
                    inEnglish = "one";
                    break;
                case 2:
                    inEnglish = "two";
                    break;
                case 3:
                    inEnglish = "three";
                    break;
                case 4:
                    inEnglish = "four";
                    break;
                case 5:
                    inEnglish = "five";
                    break;
                case 6:
                    inEnglish = "six";
                    break;
                case 7:
                    inEnglish = "seven";
                    break;
                case 8:
                    inEnglish = "eight";
                    break;
                case 9:
                    inEnglish = "nine";
                    break;
                case 0:
                    inEnglish = "zero";
                    break;
            }
            return inEnglish;
        }
    }
}
