using System;
using System.Linq;

namespace _11.EqualSums
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var intArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            FindAndPrintEqualSumsElement(intArray);
        }

        public static void FindAndPrintEqualSumsElement(int[] intArray)
        {
            var found = false;

            for (int i = 0; i < intArray.Length; i++)
            {
                var leftSum = 0;
                var rightSum = 0;

                for (int q = 0; q < i; q++)
                {
                    leftSum += intArray[q];
                }

                for (int j = i + 1; j < intArray.Length; j++)
                {
                    rightSum += intArray[j];
                }

                if (leftSum == rightSum)
                {
                    found = true;
                    Console.WriteLine(i);
                }
            }

            if (!found)
            {
                Console.WriteLine("no");
            }
        }
    }
}
