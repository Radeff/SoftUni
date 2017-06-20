using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.ListOfPredicates
{
    public class ListOfPredicates
    {
        public static void Main()
        {
            var end = int.Parse(Console.ReadLine());
            var dividers = Console.ReadLine().Split().Select(int.Parse).Distinct().ToArray();
            Func<int, int, bool> divisible = (n, d) => n % d == 0;
            var result = new List<int>();
            
            for(int num = 1; num <= end; num++)
            {
                var check = true;

                foreach (var divider in dividers)
                {
                    if (!divisible(num, divider))
                    {
                        check = false;
                        break;
                    }
                }

                if (check)
                {
                    result.Add(num);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
