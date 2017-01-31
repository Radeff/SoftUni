using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CompareCharArrays
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var stringOne = Console.ReadLine().Split(' ');
            var stringTwo = Console.ReadLine().Split(' ');
            char[] arrayOne = string.Join("", stringOne).ToCharArray();
            char[] arrayTwo = string.Join("", stringTwo).ToCharArray();

            if (arrayOne.Length <= arrayTwo.Length)
            {
                CompareAndPrintArrays(arrayOne, arrayTwo);
            }
            else
            {
                CompareAndPrintArrays(arrayTwo, arrayOne);
            }
            
        }

        public static void CompareAndPrintArrays (char[] arrayOne, char[] arrayTwo)
        {
            var found = false;
            for (int i = 0; i < arrayOne.Length - 1; i++)
            {
                if (arrayOne[i] < arrayTwo[i])
                {
                    Console.WriteLine(string.Join("", arrayOne));
                    Console.WriteLine(string.Join("", arrayTwo));
                    found = true;
                    break;
                }
                else if (arrayTwo[i] < arrayOne[i])
                {
                    Console.WriteLine(string.Join("", arrayTwo));
                    Console.WriteLine(string.Join("", arrayOne));
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine(string.Join("", arrayOne));
                Console.WriteLine(string.Join("", arrayTwo));
            }
        }
    }
}
