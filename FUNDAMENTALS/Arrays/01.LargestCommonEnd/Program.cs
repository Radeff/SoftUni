using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.LargestCommonEnd
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] arrayOne = Console.ReadLine().Split(' ');
            string[] arrayTwo = Console.ReadLine().Split(' ');
            if (arrayOne.Length >= arrayTwo.Length)
            {
                ScanArrays(arrayOne, arrayTwo);
            }
            else
            {
                ScanArrays(arrayTwo, arrayOne);
            }
        }

        public static void ScanArrays(string[] longer, string[] shorter)
        {
            bool foundLeft = false;
            var countEqualLeft = 0;

            for (int i = 0; i < shorter.Length; i++)
            {
                if (longer[i] == shorter[i])
                {
                    foundLeft = true;
                    countEqualLeft++;
                }
            }

            bool foundRight = false;
            var countEqualRight = 0;

            for (int i = longer.Length - 1; i >= (longer.Length - shorter.Length); i--)
            {
                if (shorter[i - (longer.Length - shorter.Length)] == longer[i])
                {
                    foundRight = true;
                    countEqualRight++;
                }
            }

            if (foundLeft && foundRight)
            {
                if (countEqualLeft > countEqualRight)
                {
                    Console.WriteLine(countEqualLeft);
                }

                else
                {
                    Console.WriteLine(countEqualRight);
                }

            }

            else if (foundLeft && !foundRight)
            {
                Console.WriteLine(countEqualLeft);
            }

            else if (foundRight && !foundLeft)
            {
                Console.WriteLine(countEqualRight);
            }

            else
            {
                Console.WriteLine("0");
            }

        }
    }
}
