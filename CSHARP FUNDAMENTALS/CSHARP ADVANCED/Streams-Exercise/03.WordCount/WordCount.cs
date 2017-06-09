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
            var wordsToFind = new StreamReader("../../words.txt")
                .ReadToEnd()
                .Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            var writer = new StreamWriter("../../results.txt");
            var text = new StreamReader("../../text.txt")
                .ReadToEnd()
                .ToLower()
                .Split(" .,?!-\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            var wordsCount = new Dictionary<string, int>();
            var results = new SortedDictionary<string,string>();

            foreach (var word in text)
            {
                if (!wordsCount.ContainsKey(word))
                {
                    wordsCount.Add(word, 0);
                }
                
                wordsCount[word]++;
            }

            foreach (var word in wordsToFind)
            {
                foreach (var kvp in wordsCount)
                {
                    if (word == kvp.Key)
                    {
                        results.Add(kvp.Value.ToString(), kvp.Key);
                    }
                }
            }

            using (writer)
            {

                foreach (var kvp in results.OrderByDescending(w => w.Key))
                {
                    writer.WriteLine($"{kvp.Value} - {kvp.Key}");
                }
            }
        }
    }
}
