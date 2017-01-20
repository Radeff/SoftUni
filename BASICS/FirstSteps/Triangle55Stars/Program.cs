using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle55Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 11; i++)
            {
                var stars = new string('*', i);
                Console.WriteLine(stars);
            }
            
        }
    }
}
