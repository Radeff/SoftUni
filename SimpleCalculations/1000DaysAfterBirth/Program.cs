using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1000DaysAfterBirth
{
    class Program
    {
        static void Main(string[] args)
        {
            var entryDate = Console.ReadLine();
            var newDate = DateTime.ParseExact(entryDate, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);
            newDate = newDate.AddDays(999.0);
            Console.WriteLine(newDate.ToString("dd-MM-yyyy"));
        }
    }
}
