using System;
using System.Collections.Generic;
using System.Linq;


namespace _01.MaxSequenceOfEqualElements
{
    public class Program
    {
        public static void Main()
        {
            var listOfNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            FindLongestSequence(listOfNumbers);
        }

        public static void FindLongestSequence(List<int> numbers)
        {
            var count = 0;
            var bestCount = 0;
            var pos = 0;

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    count++;
                    if (count > bestCount)
                    {
                        bestCount = count;
                        pos = i;
                    }

                }
                else
                {
                    count = 0;
                }
            }

            for (int i = 0; i < bestCount + 1; i++)
            {
                Console.Write($"{numbers[pos]} ");
            }

            Console.WriteLine();
        }
    }
}
