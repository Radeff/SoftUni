using System;
using System.Numerics;

namespace _02.ConvertFromBaseNToBase10
{
    public class ConvertFromBaseNToBase10
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split();
            var n = int.Parse(input[0]);
            var number = BigInteger.Parse(input[1]);
            BigInteger result = 0;
            int power = 0;

            while (number > 0)
            {
                result += (number % 10) * BigInteger.Pow(n, power);
                number /= 10;
                power++;
            }
            
            Console.WriteLine(result);
        }
    }
}
