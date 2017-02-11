using System.Collections.Generic;

namespace _07.AndreyAndBilliard
{
    public class Customer
    {
        public string Name { get; set; }

        public Dictionary<string, decimal> Cart { get; set; }

        public decimal Bill { get; set; }        
    }
}
