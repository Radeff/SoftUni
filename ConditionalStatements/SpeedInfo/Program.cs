using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = double.Parse(Console.ReadLine());
            if (s <= 10)
            {
                Console.WriteLine("slow");
            }
            else if (s <= 50)
            {
                Console.WriteLine("average");
            }
            else if (s <= 150)
            {
                Console.WriteLine("fast");
            }
            else if (s <= 1000)
            {
                Console.WriteLine("ultra fast");
            }
            else
            {
                Console.WriteLine("extremely fast");
            }
        }
    }
}
