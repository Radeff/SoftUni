using System;
using System.Collections.Generic;
using System.Text;

namespace _16.ExtractHyperlinks
{
    public class ExtractHyperlinks
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var hyperlinks = new List<string>();
            var openTag = "<a";
            var closeTag = ">";
            var sb = new StringBuilder();

            while (input != "END")
            {
                if (input.Contains("\t"))
                {
                    input = input.Replace("\t", " ");
                }

                sb.Append(input);
                input = Console.ReadLine();
            }

            var html = sb.ToString();

            while (html.Contains(openTag) && html.Contains(closeTag))
            {
                var startIndex = html.IndexOf(openTag);
                var htmlSplit = html.Substring(startIndex, html.Length - startIndex - 1);
                var endIndex = htmlSplit.IndexOf(closeTag);
                var splitATag = htmlSplit.Substring(htmlSplit.IndexOf(openTag), endIndex + closeTag.Length);
                var splitHREF = splitATag.Substring(splitATag.IndexOf("href"), splitATag.Length - splitATag.IndexOf("href"));

                if (splitHREF.Contains("="))
                {
                    hyperlinks.Add(splitHREF);
                    html = html.Remove(startIndex, splitATag.Length);
                }
                else
                {
                    html = html.Remove(startIndex, splitATag.Length);
                }
            }

            for (int i = 0; i < hyperlinks.Count; i++)
            {
                var link = hyperlinks[i];

                while (link.Contains("href"))
                {
                    var href = link.IndexOf("href");

                    if (link[href + 4] != ' ' && link[href + 4] != '=')
                    {
                        var linkCleaned = link.Remove(href, 4);
                        link = linkCleaned;
                        hyperlinks[i] = linkCleaned;
                    }
                    else
                    {
                        if (href == link.LastIndexOf("href"))
                        {
                            break;
                        }
                    }
                }

                if (!link.Contains("href"))
                {
                    hyperlinks.Remove(link);
                    i--;
                }
            }

            for (int i = 0; i < hyperlinks.Count; i++)
            {
                var link = hyperlinks[i];
                var hrefStart = link.IndexOf("href");

                if (link.IndexOf("=") != link.LastIndexOf("="))
                {
                    if (hrefStart > link.IndexOf("="))
                    {
                        hyperlinks[i] = link.Substring(hrefStart, link.Length - hrefStart);
                    }
                }

                switch (link[hrefStart + 4])
                {
                    case ' ':
                        link = link.Remove(hrefStart + 4, 1);
                        hyperlinks[i] = link;
                        break;

                    case '=':
                        if (link[hrefStart + 5] == ' ')
                        {
                            link = link.Remove(hrefStart + 5, 1);
                            hyperlinks[i] = link;
                        }
                        break;
                }

                if (link[hrefStart + 5] == ' ')
                {
                    link = link.Remove(hrefStart + 5, 1);
                }

                var hrefContent = link.Substring(hrefStart + 6, link.Length - hrefStart - 6);
                var hrefEnd = -1;

                switch (link[hrefStart + 5])
                {
                    case '"':
                        hrefEnd = hrefContent.IndexOf('"');
                        hrefContent = hrefContent.Remove(hrefEnd);
                        hyperlinks[i] = hrefContent;
                        break;

                    case '\'':
                        hrefEnd = hrefContent.IndexOf('\'');
                        hrefContent = hrefContent.Remove(hrefEnd);
                        hyperlinks[i] = hrefContent;
                        break;

                    default:
                        hrefContent = link.Substring(hrefStart + 5, link.Length - hrefStart - 5).TrimStart();
                        if (hrefContent.Contains(" "))
                        {
                            hrefEnd = hrefContent.IndexOf(' ');
                            hrefContent = hrefContent.Remove(hrefEnd);
                            hyperlinks[i] = hrefContent;
                        }
                        else
                        {
                            hrefEnd = hrefContent.IndexOf('>');
                            hrefContent = hrefContent.Remove(hrefEnd);
                            hyperlinks[i] = hrefContent;
                        }
                        break;
                }
            }

            foreach (var item in hyperlinks)
            {
                Console.WriteLine(item);
            }
        }
    }
}
