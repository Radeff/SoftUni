using System;
using System.Linq;
using System.Numerics;

namespace _01.ConvertFromBase10ToBaseN
{
    public class ConvertFromBase10
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().Select(BigInteger.Parse).ToArray();
            var n = input[0];
            var number = input[1];
            var result = string.Empty;

            while (number > 0)
            {
                result += number % n;
                number = number / n;
            }

            result = new string(result.ToCharArray().Reverse().ToArray());
            Console.WriteLine(result);
        }
    }
}
