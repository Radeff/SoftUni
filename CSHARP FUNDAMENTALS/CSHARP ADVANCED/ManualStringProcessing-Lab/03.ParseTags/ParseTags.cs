using System;

namespace _03.ParseTags
{
    public class ParseTags
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var openTag = "<upcase>";
            var closeTag = "</upcase>";

            while (input.Contains(openTag) && input.Contains(closeTag))
            {
                var openIndex = input.IndexOf(openTag);
                var closeIndex = input.IndexOf(closeTag);

                var tagsText = input
                    .Substring(input.IndexOf(openTag) + openTag.Length, closeIndex - openIndex - closeTag.Length + 1)
                    .ToUpper();

                input = input.Substring(0, openIndex) + tagsText + input.Substring(closeIndex + closeTag.Length);
            }

            Console.WriteLine(input);
        }
    }
}
