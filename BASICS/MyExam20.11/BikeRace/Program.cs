using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRace
{
    class Program
    {
        static void Main(string[] args)
        {
            int juniors = int.Parse(Console.ReadLine());
            int seniors = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            double j = 0.0;
            double s = 0.0;

            if (type == "trail")
            {
                j = 5.5;
                s = 7.0;
            }
            else if (type == "cross-country")
            {
                j = 8.0;
                s = 9.5;
                if (juniors + seniors >= 50)
                {
                    j -= j * 0.25;
                    s -= s * 0.25;
                }
            }
            else if (type == "downhill")
            {
                j = 12.25;
                s = 13.75;
            }
            else if (type == "road")
            {
                j = 20.0;
                s = 21.5;
            }

            double total = juniors * j + seniors * s;
            total -= total * 0.05;
            Console.WriteLine("{0:F2}", total);
        }
    }
}
