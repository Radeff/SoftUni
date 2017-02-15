using System;
using System.Linq;


namespace _06.SumBigNumbers
{
    public class SumBigNumbers
    {
        public static void Main()
        {
            var first = Console.ReadLine().ToCharArray();
            var second = Console.ReadLine().ToCharArray();

            var longer = first;
            var shorter = second;

            if (first.Length < second.Length)
            {
                longer = second;
                shorter = first;
            }

            var diff = longer.Length - shorter.Length;
            var mem = 0;
            var resultEnd = "";

            for (int i = shorter.Length - 1; i >= 0; i--)
            {
                var sum = int.Parse(shorter[i].ToString()) + int.Parse(longer[i + diff].ToString()) + mem;

                if (sum >= 10)
                {
                    mem = 1;
                    sum = sum - 10;
                }

                else
                {
                    mem = 0;
                }

                resultEnd += sum;
            }

            var reversedEnd = new string(resultEnd.ToCharArray()
                .Reverse()
                .ToArray());

            var result = "";

            if (diff > 0)
            {
                var resultStart = "";

                for (int i = diff - 1; i >= 0; i--)
                {
                    var sum = int.Parse(longer[i].ToString()) + mem;

                    if (sum >= 10)
                    {
                        mem = 1;
                        sum = sum - 10;
                    }

                    else
                    {
                        mem = 0;
                    }

                    resultStart += sum;
                }

                var reversedStart = new string(resultStart
                    .ToCharArray()
                    .Reverse()
                    .ToArray());

                result = string.Concat(reversedStart, reversedEnd);
            }

            else
            {
                result = reversedEnd;
            }

            if (mem == 1)
            {
                result = 1 + result;
            }

            Console.WriteLine(result.TrimStart('0'));
        }
    }
}