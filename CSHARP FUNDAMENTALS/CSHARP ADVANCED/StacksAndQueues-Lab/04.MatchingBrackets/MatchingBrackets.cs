using System;
using System.Collections.Generic;

namespace _04.MatchingBrackets
{
	public class MatchingBrackets
	{
		public static void Main()
		{
			var input = Console.ReadLine();
			var stack = new Stack<int>();

			for (int i = 0; i < input.Length; i++)
			{
				if (input[i] == '(')
				{
					stack.Push(i);
				}

				if (input[i] == ')')
				{
					var start = stack.Pop();
					var result = input.Substring(start, i - start + 1);
					Console.WriteLine(result);
				}
			}
		}
	}
}
