using System;
using System.Linq;
using System.Reflection;

namespace _01.HarvestingFields
{
    public class HarvestingFieldsTest
    {
        public static void Main()
        {
            var command = Console.ReadLine();
            while (command != "HARVEST")
            {
                var fieldInfo = typeof(HarvestingFields)
                    .GetFields(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);

                if (command == "private")
                {
                    foreach (var info in fieldInfo.Where(i => i.IsPrivate))
                    {
                        Console.WriteLine($"{info.Attributes.ToString().ToLower()} {info.FieldType.Name} {info.Name}");
                    }
                }
                else if (command == "protected")
                {
                    foreach (var info in fieldInfo.Where(i => i.IsFamily))
                    {
                        Console.WriteLine($"protected {info.FieldType.Name} {info.Name}");
                    }
                }
                else if (command == "public")
                {
                    foreach (var info in fieldInfo.Where(i => i.IsPublic))
                    {
                        Console.WriteLine($"{info.Attributes.ToString().ToLower()} {info.FieldType.Name} {info.Name}");
                    }
                }
                else if (command == "all")
                {
                    foreach (var info in fieldInfo)
                    {
                        if (info.IsFamily)
                        {
                            Console.WriteLine($"protected {info.FieldType.Name} {info.Name}");
                        }
                        else
                        {
                            Console.WriteLine($"{info.Attributes.ToString().ToLower()} {info.FieldType.Name} {info.Name}");
                        }
                    }
                }

                command = Console.ReadLine();
            }
        }
    }
}
