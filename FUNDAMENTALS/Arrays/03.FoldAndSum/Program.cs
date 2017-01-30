using System;
using System.Linq;


namespace _03.FoldAndSum
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            FoldAndSum(numbers);
        }

        public static void FoldAndSum(int[] numbers)
        {
            var k = numbers.Length / 4;
            var foldedOne = new int[k];
            var foldedTwo = new int[k];
            for (int i = 0; i < k; i++)
            {
                foldedOne[i] = numbers[numbers.Length - 1 - i - 3 * k];
            }

            for (int i = 0; i < k; i++)
            {
                foldedTwo[i] = numbers[numbers.Length - i - 1];
            }

            var folded = foldedOne.Concat(foldedTwo).ToArray();

            var sum = new int[2 * k];
            for (int i = k; i < numbers.Length - k; i++)
            {
                sum[i - k] = numbers[i] + folded[i - k];
            }

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
