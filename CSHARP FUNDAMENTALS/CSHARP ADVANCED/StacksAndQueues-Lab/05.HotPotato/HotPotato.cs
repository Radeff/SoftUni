using System;
using System.Collections.Generic;

namespace _05.HotPotato
{
	public class HotPotato
	{
		public static void Main()
		{
			var input = Console.ReadLine().Split();
			var queue = new Queue<string>(input);
			var n = int.Parse(Console.ReadLine());

			while (queue.Count > 1)
			{
				for (int i = 0; i < n - 1; i++)
				{
					var survivor = queue.Dequeue();
					queue.Enqueue(survivor);
				}

				Console.WriteLine($"Removed {queue.Dequeue()}");
			}

			Console.WriteLine($"Last is {queue.Peek()}");
		}
	}
}
