using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGNtoUSD
{
    class Program
    {
        static void Main(string[] args)
        {
            var BGN = double.Parse(Console.ReadLine());
            Console.WriteLine(Math.Round(BGN * 1.79549, 2) + " BGN");
        }
    }
}
