using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.SimpleTextEditor
{
    public class SimpleTextEditor
    {
        public static void Main()
        {
            var commNumber = int.Parse(Console.ReadLine());
            var textStack = new Stack<string>();
            textStack.Push("");

            for (int i = 0; i < commNumber; i++)
            {
                var commandLine = Console.ReadLine().Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (commandLine.Length > 1)
                {
                    var command = commandLine[0];
                    var arg = commandLine[1];

                    switch (command)
                    {
                        case "1":
                            textStack.Push(textStack.Peek() + arg);
                            break;

                        case "2":
                            var text = textStack.Peek();
                            var resultText = text.Substring(0, text.Length - int.Parse(arg));
                            textStack.Push(resultText);
                            break;

                        case "3":
                            var index = int.Parse(arg);
                            Console.WriteLine(textStack.Peek()[index - 1]);
                            break;
                    }
                }
                else
                {
                    if (textStack.Count > 0 && commandLine[0] == "4")
                    {
                        textStack.Pop();
                    }
                }
            }
        }
    }
}
