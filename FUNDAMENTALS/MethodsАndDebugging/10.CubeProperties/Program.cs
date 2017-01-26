using System;

namespace _10.CubeProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            var side = double.Parse(Console.ReadLine());
            var property = Console.ReadLine();
            
            switch (property)
            {
                case "face":
                    Console.WriteLine("{0:f2}", FindFaceDiagonal(side));
                    break;

                case "space":
                    Console.WriteLine("{0:f2}", FindSpaceDiagonal(side));
                    break;

                case "volume":
                    Console.WriteLine("{0:f2}", FindVolume(side));
                    break;

                case "area":
                    Console.WriteLine("{0:f2}", FindArea(side));
                    break;
            }

        }

        public static double FindFaceDiagonal(double s)
        {
            return Math.Sqrt(2 * (s * s));
        }

        public static double FindSpaceDiagonal(double s)
        {
            return Math.Sqrt(3 * (s * s));
        }

        public static double FindVolume(double s)
        {
            return s * s * s;
        }

        public static double FindArea(double s)
        {
            return 6 * (s * s);
        }
    }
}

