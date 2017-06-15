using System;
using System.Text.RegularExpressions;

namespace _11.SemanticHTML
{
    public class SemanticHTML
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var openDiv = new Regex(@"(\s*)<div(.*?(?:(\s*(?:class|id)\s*=\s*""([^""].*?)"").*?))\s*>");
            // (1 - indent) (2 - full div content) (3 - full class/id property) (4 - class/id name)
            var closeDiv = new Regex(@"(\s*)<\/div>\s*<!--(.+?)-->");
            // (1 - indent) (2 - class/id name)
            while (input != "END")
            {
                var match = openDiv.Match(input);
                // In case of an opening div tag
                if (match.Success)
                {
                    var classIdName = match.Groups[4].Value.Trim();
                    var content = match.Groups[2].Value.Replace(match.Groups[3].Value, String.Empty).Trim();
                    content = Regex.Replace(content, @"\s+", " "); // test 5 fails without this line
                    var indent = match.Groups[1].Value;

                    if (content != String.Empty)
                    {
                        Console.WriteLine($"{indent}<{classIdName} {content}>");
                    }
                    else
                    {
                        Console.WriteLine($"{indent}<{classIdName}>");
                    }
                }
                // In case of a closing div tag
                else if (closeDiv.Match(input).Success)
                {
                    match = closeDiv.Match(input);
                    var indent = match.Groups[1].Value;
                    var classIdName = match.Groups[2].Value.Trim();
                    Console.WriteLine($"{indent}</{classIdName}>");
                }
                else
                {
                    Console.WriteLine(input);
                }

                input = Console.ReadLine();
            }
        }
    }
}
