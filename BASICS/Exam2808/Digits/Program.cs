using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var first = number / 100;
            var second = (number / 10) % 10;
            var third = number % 10;
            var rows = first + second;
            var cols = first + third;
            for (int i = 1; i <= rows; i++)
            {
                for (int q = 1; q <= cols; q++)
                {
                    if (number % 5 == 0)
                    {
                        number -= first;
                    }
                    else if (number % 3 == 0)
                    {
                        number -= second;
                    }
                    else
                    {
                        number += third;
                    }
                    Console.Write(number + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
