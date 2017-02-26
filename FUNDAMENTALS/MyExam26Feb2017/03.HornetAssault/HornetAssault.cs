using System;
using System.Linq;

namespace _03.HornetAssault
{
    public class Program
    {
        public static void Main()
        {
            var beeHives = Console.ReadLine().Split().Select(long.Parse).ToList();
            var hornets = Console.ReadLine().Split().Select(long.Parse).ToList();            

            for (int i = 0; i < beeHives.Count; i++)
            {
                var hornetPower = hornets.Sum();
                
                if (hornetPower > beeHives[i])
                {
                    beeHives[i] = 0;                    
                }

                else
                {
                    beeHives[i] -= hornetPower;

                    if (hornets.Count > 0)
                    {
                        hornets.RemoveAt(0);
                    }                    
                }
            }

            if (beeHives.Any(b => b > 0))
            {
                Console.WriteLine(string.Join(" ", beeHives.Where(b => b > 0)));
            }

            else
            {
                Console.WriteLine(string.Join(" ", hornets));
            }
        }
    }
}
