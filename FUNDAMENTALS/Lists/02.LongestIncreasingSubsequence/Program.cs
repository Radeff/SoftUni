using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.LongestIncreasingSubsequence
{
    public class Program
    {
        public static void Main()
        {
            var listOfNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            FindLongestIncreasingSubsequence(listOfNumbers);
        }

        public static void FindLongestIncreasingSubsequence(List<int> numbers)
        {
            var longest = new List<int>();

            var currentLongest = new List<int>();
            currentLongest.Add(numbers[0]);

            for (int j = 0; j < numbers.Count; j++)
            {
                if (numbers[j] >= currentLongest.First())
                {
                    if (!currentLongest.Contains(numbers[j]))
                    {
                        while (numbers[j] <= currentLongest.Last())
                        {
                            currentLongest.Remove(currentLongest.Last());
                        }

                        currentLongest.Add(numbers[j]);
                    }
                }
                else
                {
                    var currentTemp = new List<int>();
                    currentTemp.Add(numbers[j]);

                    for (int q = j; q < numbers.Count; q++)
                    {
                        if (numbers[q] > currentTemp.First())
                        {
                            if (!currentTemp.Contains(numbers[q]))
                            {
                                while (numbers[q] <= currentTemp.Last())
                                {
                                    currentTemp.Remove(currentTemp.Last());
                                }

                                currentTemp.Add(numbers[q]);
                            }
                        }
                    }

                    if (currentTemp.Count > longest.Count)
                    {
                        longest.Clear();
                        longest.AddRange(currentTemp);
                    }
                }

                if (currentLongest.Count > longest.Count)
                {
                    longest.Clear();
                    longest.AddRange(currentLongest);
                }
            }

            Console.WriteLine(string.Join(" ", longest));
        }
    }
}