using System.Collections.Generic;
using System.IO;

namespace _01.File_Operations
{
    public class Program
    {
        public static void Main()
        {
            var text = File.ReadAllLines("text.txt");
            var oddLines = new List<string>();

            for (int i = 0; i < text.Length; i++)
            {
                if (i % 2 == 1)
                {
                    oddLines.Add(text[i]);
                }
            }

            File.WriteAllLines("output.txt", oddLines);

        }
    }
}
