using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInTheFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = int.Parse(Console.ReadLine());
            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());
            // Rectangle 1
            int x1 = 0;
            int y1 = 0;
            int x2 = 3 * h;
            int y2 = h;
            // Rectangle 2
            int x3 = h;
            int y3 = h;
            int x4 = 2 * h;
            int y4 = 4 * h;
            //If inside or border 
            if ((x >= x1 && x <= x2 && y >= y1 && y <= y2) || (x >= x3 && x <= x4 && y >= y3 && y <= y4))
            {
                // if border on both rectangles
                if ((x == x1 || x == x2 || x == x3 || x == x4) || (y == y1 || y == y2 || y == y3 || y == y4)) 
                {
                    // if inside or upper border of middle square in rectangle 1
                    if ((x > h && x < 2 * h && y == h) || (x >= h && x <= 2 * h && y > 0 && y < h)) 
                    {
                        Console.WriteLine("inside");
                    }
                    else
                    {
                        Console.WriteLine("border");
                    }
                }
                else
                {
                    Console.WriteLine("inside");
                }
            }
            else
            {
                Console.WriteLine("outside");
            }
        }
    }
}
