using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _19.TheaThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            int FT = int.Parse(Console.ReadLine());
            int FF = int.Parse(Console.ReadLine());
            int UT = int.Parse(Console.ReadLine());
            long d = 0;
            var hh = "00";
            var mm = "00";
            long ss = 0;

            long time = n * FT;
            long goodPics = (long)Math.Ceiling(n * FF / 100.0);
            time += goodPics * UT;
            if (time / (3600 * 24) > 0)
            {
                d = time / (3600 * 24);
                time -= 3600 * 24 * d;
            }
            if (time / 3600 > 0)
            {
                if (time / 3600 < 10)
                {
                    hh = $"0{time / 3600}";
                }
                else
                {
                    hh = $"{time / 3600}";
                }
                time -= (3600 * (time / 3600));
            }
            if (time / 60 > 0)
            {
                if (time / 60 < 10)
                {
                    mm = $"0{time / 60}";
                }
                else
                {
                    mm = $"{time / 60}";
                }
                time -= 60 * (time / 60);
            }
            ss = (int)time;
            if (ss == 0)
            {
                Console.WriteLine($"{d}:{hh}:{mm}:00");
            }
            else if (ss > 0 && ss < 10)
            {
                Console.WriteLine($"{d}:{hh}:{mm}:0{ss}");
            }
            else
            {
                Console.WriteLine($"{d}:{hh}:{mm}:{ss}");
            }
        }
    }
}
