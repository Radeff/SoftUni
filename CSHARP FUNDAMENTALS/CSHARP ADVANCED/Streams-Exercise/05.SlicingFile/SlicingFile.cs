using System;
using System.Collections.Generic;
using System.IO;

namespace _05.SlicingFile
{
    public class SlicingFile
    {
        public static void Main()
        {
            var sourceFile = "../../original.jpg";
            var destinationDirectory = "../../";
            Console.Write("Enter the number of parts to split:");
            var parts = int.Parse(Console.ReadLine());
            var files = new List<string>();

            for (int i = 0; i < parts; i++)
            {
                files.Add(destinationDirectory + $"part-{i}.jpg");
            }

            Slice(sourceFile, destinationDirectory, parts);
            Assemble(files, destinationDirectory);
        }

        public static void Slice(string sourceFile, string destinationDirectory, int parts)
        {
            using (var source = new FileStream(sourceFile, FileMode.Open, FileAccess.Read))
            {
                var fileSize = source.Length;
                long partSize = (long)Math.Ceiling((double)fileSize / parts);
                var buffer = new byte[partSize];
                var counter = 0;

                while (true)
                {
                    var bytesRead = source.Read(buffer, 0, buffer.Length);

                    if (bytesRead == 0)
                    {
                        break;
                    }

                    using (var destination = new FileStream(destinationDirectory + $"part-{counter}.jpg", FileMode.Create))
                    {
                        destination.Write(buffer, 0, bytesRead);
                        counter++;
                    }
                }
            }
        }

        public static void Assemble(List<string> files, string destinationDirectory)
        {
            var destinationFile = destinationDirectory + "assebmled.jpg";

            using (var destination = new FileStream(destinationFile, FileMode.Create, FileAccess.Write))
            {
                foreach (var file in files)
                {
                    using (var source = new FileStream(file, FileMode.Open, FileAccess.Read))
                    {
                        var buffer = new byte[4096];
                        int readBytes = source.Read(buffer, 0, buffer.Length);

                        while (readBytes != 0)
                        {
                            destination.Write(buffer, 0, readBytes);
                            readBytes = source.Read(buffer, 0, buffer.Length);
                        }
                    }
                }
            }
        }
    }
}
