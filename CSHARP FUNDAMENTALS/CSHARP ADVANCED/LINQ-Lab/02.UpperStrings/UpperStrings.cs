using System;
using System.Linq;

namespace _02.UpperStrings
{
    public class UpperStrings
    {
        public static void Main()
        {
            var text = Console.ReadLine().Split().ToList();
            text.Select(w => w.ToUpper()).ToList().ForEach(w => Console.Write(string.Concat(w, " ")));
            Console.WriteLine();
        }
    }
}
