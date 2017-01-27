using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.MasterNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            PrintAllMasterNumbersFrom1ToN(number);
        }

        public static void PrintAllMasterNumbersFrom1ToN(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                if (SumOfDigits(i) % 7 == 0 && ContainsEvenDigit(i) == true && IsPalindrome(i) == true)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    continue;
                }
            }
        }

        public static int SumOfDigits(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number = number / 10;
            }

            return sum;
        }

        public static bool ContainsEvenDigit(int number)
        {
            do
            {
                var digit = number % 10;
                if (digit % 2 == 0)
                {
                    return true;
                }
                number = number / 10;
            } while (number > 0);

            return false;
        }

        public static bool IsPalindrome(int number)
        {
            var numberString = number.ToString();
            char[] numberChars = numberString.ToCharArray();

            for (int i = 0; i < numberChars.Length / 2; i++)
            {
                if (numberChars[i] == numberChars[numberChars.Length - i - 1])
                {
                    continue;
                }

                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}
