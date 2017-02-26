using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rocket
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int dots = ((3 * n) - 2)/2;
            int space = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('.', dots) + "/" + new string(' ', space) + "\\" + new string('.', dots));
                space += 2;
                dots--;
            }
            dots++;
            space -= 2;
            Console.WriteLine(new string('.', dots) + new string('*', space+2) + new string('.', dots));
            for (int i = 0; i < n * 2; i++)
            {
                Console.WriteLine(new string('.', dots) + '|' + new string('\\', space) + '|' + new string('.', dots));
            }
            for (int i = 0; i < n/2; i++)
            {
                Console.WriteLine(new string('.', dots) + '/' + new string('*', space) + '\\' + new string('.', dots));
                dots--;
                space += 2;
            }
        }
    }
}
