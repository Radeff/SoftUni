using System;
using System.Linq;

namespace _03.FirstName
{
    public class FirstName
    {
        public static void Main()
        {
            var names = Console.ReadLine().Split().ToList();
            var letters = Console.ReadLine()
                .ToLower()
                .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            var found = names.Where(n => letters.Contains(n.ToLower()[0].ToString()))
                .OrderBy(n => n);

            if (found.Count() > 0)
            {
                Console.WriteLine(found.First());
            }
            else
            {
                Console.WriteLine("No match");
            }
        }
    }
}
