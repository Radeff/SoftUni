using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = double.Parse(Console.ReadLine());
            var w = double.Parse(Console.ReadLine());
            h *= 100;
            var rows = Math.Floor(h / 120);
            Console.WriteLine(rows);
            w = w*100 - 100;
            var desks = Math.Floor(w / 70);
            var result = rows * desks - 3;
            Console.WriteLine(result);
        }
    }
}
