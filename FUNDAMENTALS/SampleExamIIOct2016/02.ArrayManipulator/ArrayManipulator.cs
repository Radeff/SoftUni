using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ArrayManipulator
{
    public class ArrayManipulator
    {
        public static void Main()
        {            
            var array = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                var command = Console.ReadLine().Split();

                switch (command[0])
                {
                    case "end":
                        Console.WriteLine($"[{string.Join(", ", array)}]");
                        return;

                    case "exchange":
                        var index = int.Parse(command[1]);

                        if (index < 0 || index >= array.Count)
                        {
                            Console.WriteLine("Invalid index");
                            break;
                        }

                        var firstArray = array.Take(index + 1).ToList();
                        var secondArray = array.Skip(index + 1).Take(array.Count - index + 1).ToList();

                        array.Clear();
                        array.AddRange(secondArray);
                        array.AddRange(firstArray);
                        break;

                    case "max":
                    case "min":
                        var minMax = command[0];
                        var evenOdd = command[1];
                        MinMaxEvenOdd(array, minMax, evenOdd);
                        break;

                    case "first":
                    case "last":
                        var count = int.Parse(command[1]);
                        var firstLast = command[0];
                        evenOdd = command[2];
                        FirstLastEvenOdd(array, firstLast, count, evenOdd);
                        break;
                }
            }
        }

        public static void MinMaxEvenOdd(List<int> array, string minMax, string evenOdd)
        {
            var arrayPortion = array.Where(x => evenOdd == "even" ? x % 2 == 0 : x % 2 != 0).ToList();

            if (!arrayPortion.Any())
            {
                Console.WriteLine("No matches");
                return;
            }

            var index = array.LastIndexOf(minMax == "max" ? arrayPortion.Max() : arrayPortion.Min());
            Console.WriteLine(index);
        }

        public static void FirstLastEvenOdd(List<int> array, string FirstLast, int count, string evenOdd)
        {

            var arrayPortion = array.Where(x => evenOdd == "even" ? x % 2 == 0 : x % 2 != 0).ToList();

            if (count > array.Count)
            {
                Console.WriteLine("Invalid count");
                return;
            }

            else if (!arrayPortion.Any())
            {
                Console.WriteLine("[]");
                return;
            }

            else
            {
                var skip = 0;

                if (count > arrayPortion.Count)
                {
                    count = arrayPortion.Count;
                }

                else
                {
                    skip = FirstLast == "first" ? 0 : arrayPortion.Count - count;
                }

                Console.WriteLine($"[{string.Join(", ", arrayPortion.Skip(skip).Take(count))}]");
            }
        }
    }
}