using System;
using System.Linq;


namespace _08.MostFrequentNumber
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var intArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            FindMostFrequentNumber(intArray);
        }

        public static void FindMostFrequentNumber(int[] intArray)
        {
            var bestCounter = 0;
            var frequent = 0;
            var bestFrequent = 0;

            for (int i = 0; i < intArray.Length; i++)
            {
                var currentNum = intArray[i];
                var counter = 0;

                for (int j = 0; j < intArray.Length; j++)
                {
                    if (currentNum == intArray[j])
                    {
                        counter++;
                        frequent = currentNum;

                        if (counter > bestCounter)
                        {
                            bestCounter = counter;
                            bestFrequent = frequent;
                        }

                    }
                }
            }
            Console.WriteLine(bestFrequent);
        }
    }
}

