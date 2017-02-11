using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.AndreyAndBilliard
{
    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var warehouse = new Dictionary<string, decimal>();
            var input = new string[3];

            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split('-').Select(x => x).ToArray();
                var item = input[0];
                var itemPrice = decimal.Parse(input[1]);

                if (!warehouse.ContainsKey(item))
                {
                    warehouse[item] = 0M;
                }

                warehouse[item] = itemPrice;
            }

            var customers = new List<Customer>();

            while (input[0] != "end of clients")
            {
                input = Console.ReadLine().Split("-,".ToCharArray()).Select(x => x).ToArray();

                if (input[0] == "end of clients")
                {
                    break;
                }

                var name = input[0];
                var product = input[1];
                var quantity = decimal.Parse(input[2]);

                if (!warehouse.ContainsKey(product))
                {
                    continue;
                }

                var index = -1;

                if (customers.Any(x => x.Name == name))
                {
                    index = customers.FindIndex(x => x.Name == name);

                    if (!customers[index].Cart.ContainsKey(product))
                    {
                        customers[index].Cart.Add(product, 0);
                    }

                    customers[index].Cart[product] += quantity;
                }

                else
                {
                    var currentCustomer = new Customer()
                    {
                        Name = name,
                        Cart = new Dictionary<string, decimal>() { { product, quantity } },
                    };

                    customers.Add(currentCustomer);
                    index = customers.Count - 1;
                }

                customers[index].Bill = CalculateBill(customers[index].Cart, warehouse);
            }

            var totalBill = 0M;

            foreach (var customer in customers.OrderBy(x => x.Name))
            {
                totalBill += customer.Bill;
                Console.WriteLine($"{customer.Name}");

                foreach (var item in customer.Cart)
                {
                    Console.WriteLine($"-- {item.Key} - {item.Value}");
                }

                Console.WriteLine($"Bill: {customer.Bill:F2}");
            }

            Console.WriteLine($"Total bill: {totalBill:F2}");
        }

        public static decimal CalculateBill(Dictionary<string, decimal> cart, Dictionary<string, decimal> warehouse)
        {
            var bill = 0M;
            foreach (var product in cart)
            {
                bill += product.Value * warehouse[product.Key];
            }

            return bill;
        }
    }
}
