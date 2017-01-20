using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimePlus15
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            m += 15;
            if (m > 59)
            {
                m -= 60;
                h++;
                if (h > 23)
                {
                    h = 0;
                }
                if (m < 10)
                {
                    Console.WriteLine(h + ":0" + m);
                }
                else
                {
                    Console.WriteLine(h + ":" + m);
                }
            }
            else
            {
                Console.WriteLine(h + ":" + m);
            }
        }
    }
}
