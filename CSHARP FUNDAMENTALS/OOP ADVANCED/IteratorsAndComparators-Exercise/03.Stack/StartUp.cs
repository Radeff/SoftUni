using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Stack
{
    public class StartUp
    {
        public static void Main()
        {
            var stack = new Stack<string>();
            var command = Console.ReadLine().Split(new[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries).ToList();
            
            while (command[0] != "END")
            {
                switch (command[0])
                {
                    case "Push":
                        stack.Push(command.Skip(1).ToList());
                        break;

                    case "Pop":
                        stack.Pop();
                        break;
                }

                command = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            }

            for (int i = 0; i < 2; i++)
            {
                foreach (var element in stack)
                {
                    Console.WriteLine(element);
                }
            }
        }
    }
}
