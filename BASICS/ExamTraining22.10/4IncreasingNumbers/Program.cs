using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _IncreasingElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var prev = 0;
            var count = 0;
            var maxcount = 0;
            for (int i = 1; i <= n; i++)
            {
                var curr = int.Parse(Console.ReadLine());
                if (curr > prev)
                {
                    count++;
                }
                else
                {
                    count = 1;
                }
                if (count > maxcount)
                {
                    maxcount = count;
                }
                prev = curr;
            }
            Console.WriteLine(maxcount);
        }
    }
}
