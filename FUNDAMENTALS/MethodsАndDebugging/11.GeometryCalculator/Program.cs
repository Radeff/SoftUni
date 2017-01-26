using System;

namespace _11.GeometryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var figure = Console.ReadLine();

            switch (figure)
            {
                case "triangle":
                    var triangleSide = double.Parse(Console.ReadLine());
                    var height = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:f2}", CalculateTriangleArea(triangleSide, height));
                    break;

                case "rectangle":
                    var rectangleSideA = double.Parse(Console.ReadLine());
                    var rectangleSideB = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:f2}", CalculateRectangleArea(rectangleSideA, rectangleSideB));
                    break;

                case "square":
                    var squareSide = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:f2}", CalculateSquareArea(squareSide));
                    break;

                case "circle":
                    var radius = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:f2}", CalculateCircleArea(radius));
                    break;
            }
        }

        public static double CalculateTriangleArea(double side, double height)
        {
            return (side * height) / 2;
        }

        public static double CalculateRectangleArea(double sideA, double sideB)
        {
            return sideA * sideB;
        }

        public static double CalculateSquareArea(double side)
        {
            return side * side;
        }

        public static double CalculateCircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }
    }
}
