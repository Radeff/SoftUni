using System.IO;

namespace _02.LineNumbers
{
    public class LineNumbers
    {
        public static void Main()
        {
            var reader = new StreamReader("../../document.txt");
            var writer = new StreamWriter("../../new_document.txt");
            var lineCounter = 1;

            using (reader)
            {
                using (writer)
                {
                    var line = reader.ReadLine();

                    while (line != null)
                    {
                        var newline = $"{lineCounter}. " + line;
                        writer.WriteLine(newline);
                        lineCounter++;
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
