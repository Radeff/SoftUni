using System;
using System.Collections.Generic;

namespace _06.MathPotato
{
	public class MathPotato
	{
		public static void Main()
		{
			var input = Console.ReadLine().Split();
			var queue = new Queue<string>(input);
			var n = int.Parse(Console.ReadLine());
			var cycle = 1;

			while (queue.Count > 1)
			{
				for (int i = 0; i < n - 1; i++)
				{
					var survivor = queue.Dequeue();
					queue.Enqueue(survivor);
				}

				if (IsPrime(cycle))
				{
					Console.WriteLine($"Prime {queue.Peek()}");
				}
				else
				{
					Console.WriteLine($"Removed {queue.Dequeue()}");
				}

				cycle++;
			}

			Console.WriteLine($"Last is {queue.Peek()}");
		}

		public static bool IsPrime(int number)
		{
			if (number < 2)
			{
				return false;
			}

			if (number % 2 == 0)
			{
				return (number == 2);
			}

			var root = (int)Math.Sqrt((double)number);

			for (int i = 3; i <= root; i += 2)
			{
				if (number % i == 0)
				{
					return false;
				}
			}

			return true;
		}
	}
}
