using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SimpleCalculator
{
	public class SimpleCalculator
	{
		public static void Main()
		{
			var input = Console.ReadLine().Split().Reverse();
			var stack = new Stack<string>();

			foreach (var item in input)
			{
				stack.Push(item);
			}

			while (stack.Count > 1)
			{
				var firstNum = int.Parse(stack.Pop());
				var oper = stack.Pop();
				var secondNum = int.Parse(stack.Pop());

				if (oper == "+")
				{
					stack.Push((firstNum + secondNum).ToString());
				}
				else
				{
					stack.Push((firstNum - secondNum).ToString());
				}
			}

			Console.WriteLine(stack.Pop());
		}
	}
}
