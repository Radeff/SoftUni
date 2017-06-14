using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _09.QueryMess
{
    public class QueryMess
    {
        public static void Main()
        {
            var input = string.Empty;

            while (input != "END")
            {
                input = Console.ReadLine();
                var keyValue = @"([^&?]*)=([^&?]*)";
                var plus = @"(\+)+";
                var space = @"(%20)+";
                var result = new Dictionary<string, List<string>>();
                var matches = Regex.Matches(input, keyValue);

                for (int i = 0; i < matches.Count; i++)
                {
                    var key = matches[i].Groups[1].Value;
                    key = Regex.Replace(key, plus, " ").Trim();
                    key = Regex.Replace(key, space, " ").Trim();
                    key = Regex.Replace(key, @"(\s)+", " ");

                    var value = matches[i].Groups[2].Value;
                    value = Regex.Replace(value, plus, " ").Trim();
                    value = Regex.Replace(value, space, " ").Trim();
                    value = Regex.Replace(value, @"(\s)+", " ");

                    if (!result.ContainsKey(key))
                    {
                        result.Add(key, new List<string>());
                    }

                    result[key].Add(value);
                }

                foreach (var kvp in result)
                {
                    Console.Write($"{kvp.Key}=[{string.Join(", ", kvp.Value)}]");
                }

                Console.WriteLine();
            }
        }
    }
}