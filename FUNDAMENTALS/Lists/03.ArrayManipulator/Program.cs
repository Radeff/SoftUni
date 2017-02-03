using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.ArrayManipulator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var listOfNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string[] command = new string[1];

            while (command[0] != "print")
            {
                command = Console.ReadLine().Split(' ');
                ManipulateArray(listOfNumbers, command);
            }

            Console.WriteLine("[" + string.Join(", ", listOfNumbers) + "]");
        }

        public static void ManipulateArray(List<int> numbers, string[] command)
        {
            var pos = 0;

            if (command.Length > 1)
            {
                pos = int.Parse(command[1]);
            }

            if (command[0] == "add")
            {
                var num = int.Parse(command[2]);
                numbers.Insert(pos, num);
            }

            else if (command[0] == "addMany")
            {
                var manyCount = command.Length - 2;

                for (int i = 0; i < manyCount; i++)
                {
                    numbers.Insert(pos + i, int.Parse(command[2 + i]));
                }
            }

            else if (command[0] == "contains")
            {
                var num = int.Parse(command[1]);

                if (numbers.Contains(num))
                {
                    Console.WriteLine(numbers.FindIndex(x => x == num));
                }
                else
                {
                    Console.WriteLine(-1);
                }
            }

            else if (command[0] == "remove")
            {
                numbers.RemoveAt(pos);
            }

            else if (command[0] == "shift")
            {
                var rotations = pos;

                if (rotations >= numbers.Count)
                {
                    rotations = pos % numbers.Count;
                }

                for (int i = 0; i < rotations; i++)
                {
                    var current = numbers[0];
                    numbers.RemoveAt(0);
                    numbers.Add(current);
                }
            }

            else if (command[0] == "sumPairs")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    var pairSum = 0;

                    if (i + 1 == numbers.Count)
                    {
                        pairSum = numbers[i];
                        numbers.RemoveAt(i);
                    }
                    else
                    {
                        pairSum = numbers[i] + numbers[i + 1];
                        numbers.RemoveRange(i, 2);
                    }

                    numbers.Insert(i, pairSum);
                }
            }
        }
    }
}
