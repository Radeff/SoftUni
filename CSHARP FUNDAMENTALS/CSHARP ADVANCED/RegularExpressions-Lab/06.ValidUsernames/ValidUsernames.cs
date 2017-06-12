using System;
using System.Text.RegularExpressions;

namespace _06.ValidUsernames
{
    public class ValidUsernames
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var regex = new Regex(@"^[-\w]{3,16}$");

            while (input != "END")
            {
                if (regex.Match(input).Success)
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
