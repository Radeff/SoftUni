using System.IO;

namespace _04.CopyBinaryFile
{
    public class CopyBinaryFile
    {
        public static void Main()
        {
            var sourcePath = "../../lotus.jpg";
            var destinationPath = "../../copy.jpg";

            using (var source =  new FileStream(sourcePath, FileMode.Open, FileAccess.Read))
            {
                using (var destination = new FileStream(destinationPath, FileMode.Create))
                {
                    var buffer = new byte[4096];
                    var bytesRead = 0;

                    while ((bytesRead = source.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        destination.Write(buffer, 0, bytesRead);
                    }
                }
            }
        }
    }
}
