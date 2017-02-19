using System;

namespace _01.CharityMarathon
{
    public class CharityMarathon
    {
        public static void Main()
        {
            var days = int.Parse(Console.ReadLine());
            var runners = int.Parse(Console.ReadLine());
            var laps = int.Parse(Console.ReadLine());
            double lapLengthKM = double.Parse(Console.ReadLine()) / 1000;
            var capacity = int.Parse(Console.ReadLine());
            var moneyPerKm = double.Parse(Console.ReadLine());

            if (runners > days * capacity)
            {
                runners = days * capacity;
            }

            double totalDistance = runners * laps * lapLengthKM;
            double totalRaised = totalDistance * moneyPerKm;
            Console.WriteLine($"Money raised: {totalRaised:F2}");
        }
    }
}
