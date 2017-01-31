using System;
using System.Linq;

namespace _10.PairsByDifference
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var intArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var difference = int.Parse(Console.ReadLine());

            FindCountPairsByDifference(intArray, difference);
        }

        public static void FindCountPairsByDifference(int[] intArray, int diff)
        {
            var counter = 0;

            for (int i = 0; i < intArray.Length; i++)
            {
                for (int j = i + 1; j < intArray.Length; j++)
                {
                    if (Math.Abs(intArray[i] - intArray[j]) == diff)
                    {
                        counter++;
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}
