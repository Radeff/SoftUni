using System;
using System.Linq;

namespace _01.ReverseString
{
    public class ReverseString
    {
        public static void Main()
        {
            var toReverse = Console.ReadLine();
            var reversed = toReverse.ToCharArray();
            Array.Reverse(reversed);
            Console.WriteLine(reversed.ToArray());
        }
    }
}
