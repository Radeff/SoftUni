using System;
using System.Linq;

namespace _03.CustomMinFunction
{
    public class CustomMinFunction
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Func<int[], int> minFunc = ReturnMin;
            Console.WriteLine(minFunc(numbers));
        }

        private static int ReturnMin(int[] arr)
        {
            var min = int.MaxValue;

            foreach (var num in arr)
            {
                if (num < min)
                {
                    min = num;
                }
            }

            return min;
        }
    }
}
