using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.LongerLine
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());

            var x3 = double.Parse(Console.ReadLine());
            var y3 = double.Parse(Console.ReadLine());
            var x4 = double.Parse(Console.ReadLine());
            var y4 = double.Parse(Console.ReadLine());

            PrintLongerLine(x1, y1, x2, y2, x3, y3, x4, y4);

        }

        // Checks which line is longer and prints it starting from the point closest to center
        public static void PrintLongerLine(double x1, double y1, double x2, double y2,
            double x3, double y3, double x4, double y4)
        {
            var line1Length = FindLineLength(x1, x2, y1, y2);
            var line2Length = FindLineLength(x3, x4, y3, y4);

            if (line1Length >= line2Length)
            {

                if (FindHypotenuse(x1, y1) <= FindHypotenuse(x2, y2))
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }

                else
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }
            }

            else
            {
                if (FindHypotenuse(x3, y3) <= FindHypotenuse(x4, y4))
                {
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                }

                else
                {
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
                }
            }
        }

        public static double FindLineLength(double x1, double x2, double y1, double y2)
        {
            double lineLength = Math.Sqrt(((x1 - x2) * (x1 - x2)) + ((y1 - y2) * (y1 - y2)));

            return lineLength;
        }

        public static double FindHypotenuse(double sideA, double sideB)
        {
            // Distance to center is actually the hypotenuse of a right-angle triangle
            var hypotenuse = Math.Sqrt((sideA * sideA) + (sideB * sideB));
            return hypotenuse;
        }
    }
}
