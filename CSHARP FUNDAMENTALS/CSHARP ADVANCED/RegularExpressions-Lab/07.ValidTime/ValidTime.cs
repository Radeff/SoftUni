using System;
using System.Text.RegularExpressions;

namespace _07.ValidTime
{
    public class ValidTime
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var regex = new Regex(@"^(0[0-9]|1[0-2])(:[0-5][0-9]){2}\s[AP]M$");

            while (input != "END")
            {
                var match = regex.Match(input);

                if (match.Success)
                {
                    Console.WriteLine("valid");
                }
                else
                {
                    Console.WriteLine("invalid");
                }

                input = Console.ReadLine();
            }
        }
    }
}
