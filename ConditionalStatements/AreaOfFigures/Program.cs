using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            var fig = Console.ReadLine();
            if (fig == "square")
            {
                var a = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round((a * a),3));
            }
            else if (fig == "rectangle")
            {
                var a = double.Parse(Console.ReadLine());
                var b = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round((a * b),3));
            }
            else if (fig == "circle")
            {
                var r = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round((r * Math.PI * r),3));
            }
            else if (fig == "triangle")
            {
                var a = double.Parse(Console.ReadLine());
                var h = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(((a * h)/2.0), 3));
            }
        }
    }
}
