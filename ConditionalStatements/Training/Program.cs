using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sumLeft = 0;
            var sumRight = 0;
            for (int i = 0; i < n; i++)
            {
                var currentNumb = int.Parse(Console.ReadLine());
                sumLeft = sumLeft + currentNumb;
            }
            for (int i = 0; i < n; i++)
            {
                var currentNumb = int.Parse(Console.ReadLine());
                sumRight = sumRight + currentNumb;
            }
            if (sumLeft == sumRight)
            {
                Console.WriteLine("yes, sum = " + sumLeft);
            }
            else
            {
                Console.WriteLine("No, diff = " + Math.Abs(sumLeft - sumRight));
            }
        }
    }
}
