using System;

namespace _01.StudentsResults
{
    public class StudentsResults
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split("- ,".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                var name = input[0];
                var cadv = double.Parse(input[1]);
                var coop = double.Parse(input[2]);
                var advoop = double.Parse(input[3]);
                var avg = (cadv + coop + advoop) / 3.0;

                if (i == 0)
                {
                    Console.WriteLine("Name      |   CAdv|   COOP| AdvOOP|Average|");
                }

                Console.WriteLine("{0,-10}|{1,7:f2}|{2,7:f2}|{3,7:f2}|{4,7:f4}|", name, cadv, coop, advoop, avg);
            }
        }
    }
}
