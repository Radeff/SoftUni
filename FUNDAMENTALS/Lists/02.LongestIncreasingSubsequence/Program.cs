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
            var currentLongest = new List<int>();
            currentLongest.Add(numbers[0]);

            var longest = new List<int>();
            longest.Add(currentLongest[0]);

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] > currentLongest.First())
                {
                    if (!currentLongest.Contains(numbers[i]))
                    {
                        while (numbers[i] <= currentLongest.Last())
                        {
                            currentLongest.Remove(currentLongest.Last());
                        }

                        currentLongest.Add(numbers[i]);
                    }

                    if (currentLongest.Count > longest.Count)
                    {
                        longest.Clear();
                        longest.AddRange(currentLongest);
                    }
                }

                else
                {
                    var currentTemp = new List<int>();
                    currentTemp.Add(numbers[i]);

                    for (int j = i; j < numbers.Count; j++)
                    {
                        if (numbers[j] > currentTemp.First())
                        {
                            if (!currentTemp.Contains(numbers[j]))
                            {
                                while (numbers[j] <= currentTemp.Last())
                                {
                                    currentTemp.Remove(currentTemp.Last());
                                }

                                currentTemp.Add(numbers[j]);
                            }

                            if (currentTemp.Count > longest.Count)
                            {
                                longest.Clear();
                                longest.AddRange(currentTemp);
                            }
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", longest));
        }
    }
}