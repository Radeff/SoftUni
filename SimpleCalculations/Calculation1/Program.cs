using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculation1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            var side = double.Parse(Console.ReadLine());
            var area = side * side;
            Console.Write("Square = ");
            Console.WriteLine(area);
        }
    }
}
