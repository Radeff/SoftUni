using System;
using System.Linq;

namespace _04.AddVAT
{
    public class AddVAT
    {
        public static void Main()
        {
            Func<string, double> NumberParser = n => double.Parse(n);
            Func<double, double> AddVat = n => n * 1.2;
            var numbers = Console.ReadLine()
                .Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(NumberParser)
                .Select(AddVat);

            foreach (var number in numbers)
            {
                Console.WriteLine($"{number:F2}");
            }
        }
    }
}
