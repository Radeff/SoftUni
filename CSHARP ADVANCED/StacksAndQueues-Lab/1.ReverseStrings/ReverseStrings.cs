using System;
using System.Collections.Generic;

namespace _1.ReverseStrings
{
	public class ReverseStrings
	{
		public static void Main()
		{
			var input = Console.ReadLine();
			var stack = new Stack<char>();

			foreach (var c in input)
			{
				stack.Push(c);
			}

			for (var i = 0; i < input.Length; i++)
			{
				Console.Write(stack.Pop());
			}

			Console.WriteLine();
		}
	}
}
