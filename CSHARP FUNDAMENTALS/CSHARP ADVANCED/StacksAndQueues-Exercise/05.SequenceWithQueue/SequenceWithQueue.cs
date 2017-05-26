using System;
using System.Collections.Generic;

namespace _05.SequenceWithQueue
{
    public class SequenceWithQueue
    {
        public static void Main()
        {
            var first = long.Parse(Console.ReadLine());
            var queue = new Queue<long>();
            queue.Enqueue(first);

            for (int i = 0; i < 50; i++)
            {
                first = queue.Peek();
                var second = first + 1;
                var third = 2 * first + 1;
                var fourth = first + 2;

                queue.Enqueue(second);
                queue.Enqueue(third);
                queue.Enqueue(fourth);
                
                Console.Write(queue.Peek() + " ");
                queue.Dequeue();
            }

            Console.WriteLine();
        }
    }
}
