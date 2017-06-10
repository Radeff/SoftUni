using System;
using System.Linq;

namespace _08.MultiplyBigNumber
{
    public class MultiplyBigNumber
    {
        public static void Main()
        {
            var number = Console.ReadLine()
                .TrimStart('0')
                .ToCharArray();

            var multiplier = int.Parse(Console.ReadLine());

            if (multiplier == 0)
            {
                Console.WriteLine(0);
                return;
            }

            var result = String.Empty;
            var mem = 0;

            for (int i = number.Length - 1; i >= 0; i--)
            {
                var sum = int.Parse(number[i].ToString()) * multiplier + mem;

                if (sum > 9)
                {
                    mem = sum / 10;
                    sum = sum % 10;
                }

                else
                {
                    mem = 0;
                }

                result = string.Concat(result, sum);
            }

            var reversedResult = new string(result
                .ToCharArray()
                .Reverse()
                .ToArray());

            if (mem != 0)
            {
                Console.WriteLine(string.Concat(mem, reversedResult));
            }

            else
            {
                Console.WriteLine(reversedResult);
            }
        }
    }
}
