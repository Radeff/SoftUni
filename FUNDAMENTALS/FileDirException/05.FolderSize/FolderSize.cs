using System.IO;
using System.Linq;

namespace _05.FolderSize
{
    public class Folder
    {
        public static void Main()
        {
            var dir = new DirectoryInfo("./TestFolder");
            var files = dir.GetFiles();

            File.WriteAllText("output.txt", files.Sum(x => x.Length / 1024.0 / 1024.0).ToString());
        }
    }
}
