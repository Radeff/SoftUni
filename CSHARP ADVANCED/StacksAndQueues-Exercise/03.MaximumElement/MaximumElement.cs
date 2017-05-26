using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MaximumElement
{
    public class MaximumElement
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var numbers = new Stack<int>();
            var max = int.MinValue;
            var maxNumbers = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                if (input.Length > 1)
                {
                    numbers.Push(input[1]);

                    if (max < input[1])
                    {
                        max = input[1];
                        maxNumbers.Push(max);
                    }
                }
                else
                {
                    if (input[0] == 2)
                    {
                        if (numbers.Pop() == max)
                        {
                            maxNumbers.Pop();

                            if (maxNumbers.Count > 0)
                            {
                                max = maxNumbers.Peek();
                            }
                            else
                            {
                                max = int.MinValue;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine(max);
                    }
                }
            }
        }
    }
}
