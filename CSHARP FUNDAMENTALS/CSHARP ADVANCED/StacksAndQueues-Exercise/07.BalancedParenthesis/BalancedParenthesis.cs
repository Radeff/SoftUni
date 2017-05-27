using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.BalancedParenthesis
{
    public class BalancedParenthesis
    {
        public static void Main()
        {
            var brackets = Console.ReadLine();
            var opened = new char[] {'(', '[', '{'};
            var openBrackets = new Stack<char>();

            foreach (var bracket in brackets)
            {
                if (opened.Contains(bracket))
                {
                    openBrackets.Push(bracket);
                }
                else
                {
                    if (openBrackets.Count == 0)
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                    switch (bracket)
                    {
                        case ')':
                            if (openBrackets.Pop() != '(')
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                            break;

                        case ']':
                            if (openBrackets.Pop() != '[')
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                            break;

                        case '}':
                            if (openBrackets.Pop() != '{')
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                            break;
                    }
                }
            }

            Console.WriteLine("YES");
        }
    }
}
