using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace _10.UseYourChainsBuddy
{
    public class UseYourChainsBuddy
    {
        public static void Main()
        {

            Console.SetIn(new StreamReader(Console.OpenStandardInput(8192)));
            var encoded = Console.ReadLine();

            var pattern = new Regex(@"<p>(.*?)<\/p>");
            var matches = pattern.Matches(encoded);
            var cleanPattern = @"[^a-z0-9\s]";
            var space = @"\s+";

            var encrypted = new List<string>();
            foreach (Match match in matches)
            {
                var text = match.Groups[1].Value;
                text = Regex.Replace(text, cleanPattern, " ");
                text = Regex.Replace(text, space, " ");
                encrypted.Add(text);
            }

            var decrypted = new List<string>();
            foreach (var word in encrypted)
            {
                var decryptedWord = word
                    .ToCharArray()
                    .Select(x => x = (x > 96 && x < 123) ? (x = (x > 96 && x < 110) ? (char)(x + 13) : (char)(x - 13)) : x).ToArray();
                decrypted.Add(new string(decryptedWord));
            }

            Console.WriteLine(string.Join("", decrypted));
        }
    }
}
