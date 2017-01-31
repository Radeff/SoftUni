using System;
using System.Linq;


namespace _07.MaxSequenceOfIncreasingElements
{
    class Program
    {
        public static void Main(string[] args)
        {
            var intArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            FindLongestSequelOfIncreasing(intArray);
        }

        public static void FindLongestSequelOfIncreasing(int[] intArray)
        {
            var previous = intArray[0];
            var bestCounter = 0;
            var bestPos = intArray.Length;
            var counter = 0;
            var startPos = intArray.Length;

            for (int i = 1; i < intArray.Length; i++)
            {
                if (previous < intArray[i])
                {
                    counter++;
                    startPos = i - counter;

                    if (counter > bestCounter)
                    {
                        bestCounter = counter;
                        bestPos = startPos;
                    }

                    previous = intArray[i];
                }

                else
                {
                    counter = 0;
                    previous = intArray[i];
                }

            }

            if (bestCounter > 0)
            {
                for (int i = bestPos; i <= bestPos + bestCounter; i++)
                {
                    Console.Write($"{intArray[i]} ");
                }

                Console.WriteLine();
            }
        }
    }
}
