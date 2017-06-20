using System;

namespace _07.PredicateForNames
{
    public class PredicateForNames
    {
        public static void Main()
        {
            var length = int.Parse(Console.ReadLine());
            var names = Console.ReadLine().Split();
            Func<int, string, bool> nameLimit = (i, s) => s.Length <= i;
            FilterAndPrintNames(length, names, nameLimit);
        }

        private static void FilterAndPrintNames(int length, string[] names, Func<int, string, bool> nameLimit)
        {
            foreach (var name in names)
            {
                if (nameLimit(length,name))
                {
                    Console.WriteLine(name);
                }
            }
        }
    }
}
