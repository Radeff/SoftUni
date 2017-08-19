using System;

namespace _06.CustomEnumAttribute
{
    public class StartUp
    {
        
        public static void Main()
        {
            var inputLine = Console.ReadLine();
            var customAttributes = typeof(CardRank).GetCustomAttributes(false);

            if (inputLine == "Suit")
            {
                customAttributes = typeof(CardSuit).GetCustomAttributes(false);
            }

            foreach (TypeAttribute attr in customAttributes)
            {
                Console.WriteLine($"Type = {attr.Type}, Description = {attr.Description}");
            }
        }
    }
}