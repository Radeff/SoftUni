using System;

namespace _04.FindEvensOrOdds
{
    public class FindEvensOrOdds
    {
        public static void Main()
        {
            var range = Console.ReadLine().Split();
            var start = int.Parse(range[0]);
            var end = int.Parse(range[1]);
            var oddEvenFilter = Console.ReadLine();

            Predicate<int> odd = n => n % 2 != 0;
            Predicate<int> even = n => n % 2 == 0;

            for (int i = start; i <= end; i++)
            {
                if (oddEvenFilter == "odd")
                {
                    if (odd(i))
                    {
                        Console.Write(string.Concat(i, " "));
                    }
                }
                else
                {
                    if (even(i))
                    {
                        Console.Write(string.Concat(i, " "));
                    }
                }
            }
        }
    }
}
