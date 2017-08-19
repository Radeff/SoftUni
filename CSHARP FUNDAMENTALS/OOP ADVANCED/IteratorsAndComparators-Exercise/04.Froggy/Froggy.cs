using System;
using System.Linq;

namespace _04.Froggy
{
    public class Froggy
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var lake = new Lake(input);

            Console.WriteLine(string.Join(", ", lake));
        }
    }
}
