using System;
using System.Linq;

namespace _03.IntersectionOfCircles
{
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var firstCircle = new Circle()
            {
                Radius = input[2],
                Center = new Point()
                {
                    X = input[0],
                    Y = input[1]
                }
            };

            input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var secondCircle = new Circle()
            {
                Radius = input[2],
                Center = new Point()
                {
                    X = input[0],
                    Y = input[1]
                }
            };

            if (Intersect(firstCircle, secondCircle))
            {
                Console.WriteLine("Yes");
            }

            else
	        {
                Console.WriteLine("No");
            }

        }

        public static bool Intersect(Circle firstCircle, Circle secondCircle)
        {
            var distance = Math.Sqrt(
                Math.Pow((secondCircle.Center.X - firstCircle.Center.X), 2)
                + Math.Pow((secondCircle.Center.Y - firstCircle.Center.Y), 2)
                );

            if (distance <= firstCircle.Radius + secondCircle.Radius)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }

    public class Circle
    {
        public double Radius { get; set; }
        public Point Center { get; set; }
    }

    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
    }
}
