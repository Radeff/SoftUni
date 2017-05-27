using System;
using System.Collections.Generic;

namespace _09.StackFibonacci
{
    public class StackFibonacci
    {
        public static void Main()
        {
            var nthNumber = int.Parse(Console.ReadLine());
            var result = GetFibonacci(nthNumber);
            Console.WriteLine(result);
        }

        private static long GetFibonacci(int nthNumber)
        {
            var fibStack = new Stack<long>();
            fibStack.Push(0);
            fibStack.Push(1);

            for (int i = 0; i < nthNumber - 1; i++)
            {
                var current = fibStack.Pop();
                var previous = fibStack.Pop();
                var next = previous + current;
                fibStack.Push(current);
                fibStack.Push(next);
            }

            return fibStack.Peek();
        }
    }
}
