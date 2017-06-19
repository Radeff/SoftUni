using System;

namespace _02.KnightsOfHonor
{
    public class KnightsOfHonor
    {
        public static void Main()
        {
            var names = Console.ReadLine().Split(" \t".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            Action<string> addTitleAndPrint = s => Console.WriteLine(string.Concat("Sir ", s));
            foreach (var name in names)
            {
                addTitleAndPrint(name);
            }
        }
    }
}
