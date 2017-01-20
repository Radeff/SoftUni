using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _10.CenturiesToNanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger century = BigInteger.Parse(Console.ReadLine());
            Console.WriteLine(century + " centuries = " 
                + century * 100 + " years = "
                + century * 365242 / 10 + " days = " 
                + century * 365242 / 10 * 24 + " hours = " 
                + century * 365242 / 10 * 24 * 60 + " minutes = " 
                + century * 365242 / 10 * 24 * 60 * 60 + " seconds = " 
                + century * 365242 / 10 * 24 * 60 * 60 * 1000 + " milliseconds = "
                + century * 365242 / 10 * 24 * 60 * 60 * 1000000 + " microseconds = "
                + century * 365242 / 10 * 24 * 60 * 60 * 1000000000 + " nanoseconds");
        }
    }
}
