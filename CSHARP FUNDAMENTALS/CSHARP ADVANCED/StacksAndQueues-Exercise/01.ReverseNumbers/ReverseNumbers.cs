using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.ReverseNumbers
{
    public class ReverseNumbers
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var stack = new Stack<int>();

            foreach (var number in input)
            {
                stack.Push(number);
            }

            while (stack.Count > 1)
            {
                Console.Write(stack.Pop() + " ");
            }

            Console.WriteLine(stack.Pop());
        }
    }
}
