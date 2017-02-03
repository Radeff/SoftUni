using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.SumReversedNumbers
{
    public class Program
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            PrintReversedSum(input);
        }

        public static void PrintReversedSum(string[] input)
        { 
            var numbers = new List<int>();
            var sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                numbers.Add(int.Parse(new string(input[i].ToCharArray().Reverse().ToArray())));
                sum += numbers[i];
            }

            Console.WriteLine(sum);
        }
    }
}
