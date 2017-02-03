using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.BombNumbers
{
    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var bombStats = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            BombAndPrintRemainingSum(numbers, bombStats);
        }

        public static void BombAndPrintRemainingSum(List<int> numbers, int[] bombStats)
        {
            var bomb = bombStats[0];
            var bombPow = bombStats[1];

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bomb)
                {
                    for (int j = 0; j < bombPow; j++)
                    {
                        if (i + 1 < numbers.Count)
                        {
                            numbers.RemoveAt(i + 1);
                        }                        
                    }

                    for (int q = 0; q <= bombPow; q++)
                    {
                        if (i - q >= 0)
                        {
                            numbers.RemoveAt(i - q);
                        }
                        else
                        {
                            if (numbers.Count > 0)
                            {
                                numbers.RemoveAt(numbers.First());
                                break;
                            }
                        }
                    }

                    i = - 1;
                }
            }

            long sum = 0;

            if (numbers.Count > 0)
            {
                foreach (var num in numbers)
                {
                    sum += num;
                }
            }
            
            Console.WriteLine(sum);
        }
    }
}
