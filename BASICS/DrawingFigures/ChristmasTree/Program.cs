using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasTree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int stars = 1;
            Console.WriteLine(new string(' ', n) + " | " + new string(' ', n));
            for (int i = n - 1; i >= 0; i--)
            {
                Console.WriteLine(new string(' ', i) + new string('*', stars) + " | " + new string('*', stars) + new string(' ', i));
                stars++;
            }
        }
    }
}
