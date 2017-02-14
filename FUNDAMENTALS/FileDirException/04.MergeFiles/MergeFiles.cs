using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _04.MergeFiles
{
    public class MergeFiles
    {
        public static void Main()
        {
            var merged = new List<string>();
            merged.AddRange(File.ReadAllLines("input1.txt").ToList());
            merged.AddRange(File.ReadAllLines("input2.txt").ToList());

            File.WriteAllLines("output.txt", merged.OrderBy(x => x));            
        }
    }
}
