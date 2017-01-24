using System;

namespace _02.MaxMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNum = int.Parse(Console.ReadLine());
            var secondNum = int.Parse(Console.ReadLine());
            var thirdNum = int.Parse(Console.ReadLine());

            Console.WriteLine(GetMax(GetMax(firstNum, secondNum), GetMax(secondNum, thirdNum)));
        }
        public static int GetMax(int a, int b)
        {
            return Math.Max(a,b);
        }
    }
}
