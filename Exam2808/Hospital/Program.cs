using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            int treated = 0;
            int untreated = 0;
            int docs = 7;
            for (int i = 1; i <= days; i++)
            {
                var pats = int.Parse(Console.ReadLine());
                if (i % 3 == 0)
                {
                    if (untreated > treated)
                    {
                        docs++;
                    }
                }
                if (pats <= docs)
                {
                    treated += pats;
                }
                else
                {
                    treated += docs;
                    untreated += pats - docs;
                }
            }
            Console.WriteLine("Treated patients: {0}.", treated);
            Console.WriteLine("Untreated patients: {0}.", untreated);
        }
    }
}
