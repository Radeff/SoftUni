using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04.CubicMessages
{
    public class CubicMessages
    {
        public static void Main()
        {            
            while (true)
            {
                var encrypted = Console.ReadLine();

                if (encrypted == "Over!")
                {
                    break;
                }

                var length = string.Concat("{", Console.ReadLine(), "}");
                var pattern = new Regex($@"^(\d+)([a-zA-z]{length})([^a-zA-Z]*)$");
                var match = pattern.Match(encrypted);

                if (match.Success)
                {
                    var n = 0;
                    var digitsBefore = match.Groups[1].Value.Select(x => (int.TryParse(x.ToString(), out n) ? n : -1)).ToList();
                    var digitsAfter = match.Groups[3].Value.Select(x => (int.TryParse(x.ToString(), out n) ? n : -1)).ToList();
                    var indexes = new List<int>();
                    indexes.AddRange(digitsBefore.Where(d => d != -1));
                    indexes.AddRange(digitsAfter.Where(d => d != -1));
                    var message = match.Groups[2].Value;
                    var decrypted = string.Empty;

                    foreach (var i in indexes)
                    {
                        if (i >= 0 && i < message.Length)
                        {
                            decrypted = string.Concat(decrypted, message[i]);
                        }

                        else
                        {
                            decrypted = string.Concat(decrypted, " ");
                        }
                    }

                    Console.WriteLine($"{message} == {decrypted}");
                }
            }
        }
    }
}
