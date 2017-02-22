using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04.Files
{
    public class Files
    {
        public static void Main()
        {
            var numberOfLines = int.Parse(Console.ReadLine());
            var files = new List<File>();

            for (int i = 0; i < numberOfLines; i++)
            {
                var input = Console.ReadLine().Split(';');
                var pathFile = input[0];
                var size = input[1];
                
                var pattern = new Regex(@"^(\w:|\w+).*\\(.*\.(\w+))$"); // Gets root (gr1), file.ext (gr2) and ext (gr3)
                var fileMatch = pattern.Match(pathFile);
                var fileName = fileMatch.Groups[2].Value;
                var fileExt = fileMatch.Groups[3].Value;                
                var root = fileMatch.Groups[1].Value; 

                var file = new File()
                {
                    Name = fileName,
                    Ext = fileExt,
                    Size = long.Parse(size),
                    Root = root
                };

                if (files.Any(x => x.Root == root && x.Name == fileName))
                {
                    files.RemoveAt(files.FindIndex(x => x.Root == root && x.Name == fileName && x.Ext == fileExt));
                }

                files.Add(file);
            }

            var search = Console.ReadLine();
            var searchPattern = new Regex(@"(\w+)\s\w+\s(.*)"); // Gets root in gr2 and ext in gr1
            var match = searchPattern.Match(search);
            var folder = match.Groups[2].Value;
            var ext = match.Groups[1].Value;                    
            var found = false;

            foreach (var file in files.OrderByDescending(x => x.Size).ThenBy(x => x.Name))
            {
                if (file.Root == folder && file.Ext == ext)
                {
                    Console.WriteLine($"{file.Name} - {file.Size} KB");
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("No");
            }
        }
    }    
}
