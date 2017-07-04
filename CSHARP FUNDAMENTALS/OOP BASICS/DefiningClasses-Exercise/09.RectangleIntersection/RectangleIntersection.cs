using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.RectangleIntersection
{
    public class RectangleIntersection
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split();
            var n = int.Parse(input[0]);
            var m = int.Parse(input[1]);
            var rectangles = new List<Rectangle>();

            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split();
                var rectangle = new Rectangle(
                    input[0],
                    double.Parse(input[1]),
                    double.Parse(input[2]),
                    double.Parse(input[3]),
                    double.Parse(input[4])
                    );

                rectangles.Add(rectangle);
            }

            for (int i = 0; i < m; i++)
            {
                var pairToCheck = Console.ReadLine().Split();
                var firstRect = rectangles.First(r => r.Id == pairToCheck[0]);
                var secondRect = rectangles.First(r => r.Id == pairToCheck[1]);
                
                if (firstRect.Intersection(secondRect))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
        }
    }
}
