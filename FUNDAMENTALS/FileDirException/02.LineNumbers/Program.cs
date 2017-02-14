using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.LineNumbers
{
    public class Program
    {
        public static void Main()
        {
            var lines = File.ReadAllLines("text.txt");
            var numberedLines = new string[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {                
                numberedLines[i] = string.Concat($"{i+1}. ", lines[i]);
            }

            File.WriteAllLines("output.txt", numberedLines);
        }
    }
}
