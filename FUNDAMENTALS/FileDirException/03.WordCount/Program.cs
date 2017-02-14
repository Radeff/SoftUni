using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _03.WordCount
{
    public class WordCount
    {
        public static void Main()
        {
            var words = File.ReadAllText("words.txt").Split();
            var text = File.ReadAllText("text.txt").Split($"?!, -.{Environment.NewLine}".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            var result = new SortedDictionary<int, string>();

            foreach (var word in words)
            {
                var counter = 0;
                foreach (var w in text)
                {
                    if (string.Compare(w, word, true) == 0)
                    {
                        counter++;
                    }
                }

                result.Add(counter, word);
            }

            File.WriteAllLines("output.txt", result
                .OrderByDescending(x => x.Key)
                .Select(x => string.Concat(x.Value, " - ", x.Key)));
        }
    }
}
