using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondsToMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            var time1 = int.Parse(Console.ReadLine());
            var time2 = int.Parse(Console.ReadLine());
            var time3 = int.Parse(Console.ReadLine());
            var sum = time1 + time2 + time3;
            var min = 0;
            var sec = 0;
            string minZero = "";
            string secZero = "";
            if (sum < 60)
            {
                sec = sum;
                if (sum < 10)
                {
                    secZero = "0";
                }
            }
            else if (sum < 120)
            {
                min = 1;
                sec = sum - 60;
                if (sec < 10)
                {
                    secZero = "0";
                }
            }
            else if (sum < 180)
            {
                min = 2;
                sec = sum - 120;
                if (sec < 10)
                {
                    secZero = "0";
                }
            }
            Console.WriteLine(minZero + min + ":" + secZero + sec);
        }
    }
}
