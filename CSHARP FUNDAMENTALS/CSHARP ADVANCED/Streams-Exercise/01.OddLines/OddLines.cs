using System;
using System.IO;

namespace _01.OddLines
{
    public class OddLines
    {
        public static void Main()
        {
            var reader = new StreamReader("../../document.txt");
            using (reader)
            {
                var line = reader.ReadLine();
                var lineCounter = 1;

                while (line != null)
                {
                    if (lineCounter % 2 != 0)
                    {
                        Console.WriteLine(line);
                    }

                    lineCounter++;
                    line = reader.ReadLine();
                }
            }
        }
    }
}
