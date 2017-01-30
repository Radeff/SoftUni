using System;
using System.Linq;

namespace _02.RotateAndSum
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());

            RotateAndSumArray(numbers, k);
        }

        public static void RotateAndSumArray(int[] numbers, int k)
        {
            var sum = new int[numbers.Length];
            for (int i = 1; i <= k; i++)
            {
                var lastNumber = numbers[numbers.Length - 1];

                for (int j = numbers.Length - 1; j > 0; j--)
                {
                    numbers[j] = numbers[j - 1];

                    sum[j] += numbers[j];
                }

                numbers[0] = lastNumber;
                sum[0] += numbers[0];
            }

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
