using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipePool
{
    class Program
    {
        static void Main(string[] args)
        {
            var V = int.Parse(Console.ReadLine());
            var P1 = int.Parse(Console.ReadLine());
            var P2 = int.Parse(Console.ReadLine());
            var H = double.Parse(Console.ReadLine());
            var resultP1 = (H * P1);
            var resultP2 = (H * P2);
            var Pipe1 = resultP1 / (resultP1 + resultP2) * 100;
            var Pipe2 = resultP2 / (resultP1 + resultP2) * 100;


            if (V >= (resultP1 + resultP2))
            {
                Console.WriteLine("The pool is " + Math.Truncate((resultP1 + resultP2) / V * 100) + "% full. Pipe 1: " + Math.Truncate(Pipe1) + "%. Pipe 2: " + Math.Truncate(Pipe2) + "%.");
            }
            else
            {
                Console.WriteLine("For " + H + " hours the pool overflows with " + ((resultP1 + resultP2) - V) + " liters.");
            }
        }
    }
}
