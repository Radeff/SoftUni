using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    class Program
    {
        static void Main(string[] args)
        {
            int bitc = int.Parse(Console.ReadLine()) * 1168;
            double yuan = double.Parse(Console.ReadLine()) * (1.76 * 0.15);
            double comm = double.Parse(Console.ReadLine());
            var euro = (bitc + yuan) / 1.95;
            euro = euro - (euro * comm / 100);
            Console.WriteLine(euro);
        }
    }
}
