using System;
using System.Text.RegularExpressions;


namespace _02.MatchPhoneNumber
{
    public class MatchPhoneNumber
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var regex = new Regex(@"^\+359([- ])2\1\d{3}\1\d{4}$");

            while (input != "end")
            {
                var match = regex.Match(input);
                if (match.Success)
                {
                    Console.WriteLine(match.ToString());
                }

                input = Console.ReadLine();
            }
        }
    }
}
