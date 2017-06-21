using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _13.OfficeStuff
{
    public class OfficeStuff
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var companies = new List<Company>();
            var regex = @"^\|(\w+)\s-\s(\d+)\s-\s(\w+)\|$";
            // 1 - company name, 2 - amount, 3 - product

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                var match = Regex.Match(input, regex);
                if (match.Success)
                {
                    var name = match.Groups[1].Value;
                    var amount = long.Parse(match.Groups[2].Value);
                    var product = match.Groups[3].Value;
                    var company = new Company() { Name = name };

                    if (!companies.Any(c => c.Name == company.Name))
                    {
                        company.Products = new Dictionary<string, long>();
                        company.Products.Add(product, amount);
                        companies.Add(company);
                    }
                    else
                    {
                        if (!companies.Find(c => c.Name == company.Name).Products.ContainsKey(product))
                        {
                            companies.Find(c => c.Name == company.Name).Products.Add(product, amount);
                        }
                        else
                        {
                            companies.Find(c => c.Name == company.Name).Products[product] += amount;
                        }
                    }
                }
                
            }

            foreach (var c in companies.OrderBy(c => c.Name))
            {
                Console.WriteLine($"{c.Name}: {string.Join(", ", c.Products.Select(p => $"{p.Key}-{p.Value}"))}");
            }
        }
    }

    public class Company
    {
        public string Name { get; set; }

        public Dictionary<string, long> Products { get; set; }
    }
}
