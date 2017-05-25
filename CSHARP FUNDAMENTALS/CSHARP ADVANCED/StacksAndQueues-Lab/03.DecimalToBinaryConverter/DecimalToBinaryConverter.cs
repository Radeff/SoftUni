using System;
using System.Collections.Generic;

namespace _03.DecimalToBinaryConverter
{
	public class DecimalToBinaryConverter
	{
		public static void Main()
		{
			var numToConvert = int.Parse(Console.ReadLine());
			var stack = new Stack<int>();

			if (numToConvert == 0)
			{
				Console.WriteLine(0);
			}
			else
			{
				while (numToConvert != 0)
				{
					stack.Push(numToConvert % 2);
					numToConvert /= 2;
				}
			}

			while (stack.Count > 0)
			{
				Console.Write(stack.Pop());
			}

			Console.WriteLine();
		}
	}
}
