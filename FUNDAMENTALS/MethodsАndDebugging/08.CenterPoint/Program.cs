using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CenterPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());

            var result = FindPointClosestToCenter(x1, y1, x2, y2);

            Console.WriteLine(result);
        }

        public static string FindPointClosestToCenter(double x1, double y1, double x2, double y2)
        {
            if (FindDistanceToCenter(x1, y1) < FindDistanceToCenter(x2, y2))
            {
                return $"({x1}, {y1})";
            }
            else
            {
                return $"({x2}, {y2})";
            }
        }

        public static double FindDistanceToCenter(double sideA, double sideB)
        {
            // Distance to center is actually the hypotenuse of a right-angle triangle
            var hypotenuseDistance = Math.Sqrt((sideA * sideA) + (sideB * sideB));
            return hypotenuseDistance;
        }  
    }
}
