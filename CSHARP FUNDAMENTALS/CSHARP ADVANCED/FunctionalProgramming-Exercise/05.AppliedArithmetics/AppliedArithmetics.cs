using System;
using System.Linq;

namespace _05.AppliedArithmetics
{
    public class AppliedArithmetics
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var command = Console.ReadLine();

            while (command != "end")
            {
                if (command == "add")
                {
                    ForEach(numbers, n => n+1);
                }
                else if (command == "subtract")
                {
                    ForEach(numbers, n => n-1);
                }
                else if (command == "multiply")
                {
                    ForEach(numbers, n => n * 2);
                }
                else if (command == "print")
                {
                    Console.WriteLine(string.Join(" ", numbers));
                }

                command = Console.ReadLine();
            }
        }

        public static int[] ForEach (int[] arr, Func<int, int> function)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                var temp = function(arr[i]);
                arr[i] = temp;
            }

            return arr;
        }
    }
}
