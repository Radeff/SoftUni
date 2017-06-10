using System;
using System.Linq;
using System.Numerics;
using System.Text;

namespace _04.ConvertFromBase10ToBaseN
{
    class ConvertFromBase10ToBaseN
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().Select(BigInteger.Parse).ToArray();
            var n = input[0];
            var number = input[1];
            var sb = new StringBuilder();

            while (number > 0)
            {
                sb.Append(number % n);
                number = number / n;
            }

            var toReverse = sb.ToString().ToCharArray();
            Array.Reverse(toReverse);
            var result = toReverse.ToArray();
            Console.WriteLine(result);
        }
    }
}
