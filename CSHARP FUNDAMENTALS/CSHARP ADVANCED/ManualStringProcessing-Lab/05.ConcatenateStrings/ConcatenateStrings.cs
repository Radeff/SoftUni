using System;
using System.Text;

namespace _05.ConcatenateStrings
{
    public class ConcatenateStrings
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var sb = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                sb.Append(Console.ReadLine());
                if (i == n-1)
                {
                    break;
                }
                sb.Append(" ");
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
