using System;
using System.Globalization;
using System.Linq;

namespace _01.CountWorkingDays
{
    public class Program
    {
        public static void Main()
        {
            var startDate = new DateTime();
            startDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            var endDate = new DateTime();
            endDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            var workDaysCounter = 0;

            var holidays = new DateTime[]{
                new DateTime(2000, 1, 1),
                new DateTime(2000, 3, 3),
                new DateTime(2000, 5, 1),
                new DateTime(2000, 5, 6),
                new DateTime(2000, 5, 24),
                new DateTime(2000, 9, 6),
                new DateTime(2000, 9, 22),
                new DateTime(2000, 11, 1),
                new DateTime(2000, 12, 24),
                new DateTime(2000, 12, 25),
                new DateTime(2000, 12, 26),
            };

            for (DateTime i = startDate; i <= endDate; i = i.AddDays(1.0))
            {
                for (int j = 0; j < holidays.Length; j++)
                {
                    var tempDate = holidays[j];
                    holidays[j] = new DateTime(i.Year, tempDate.Month, tempDate.Day);
                }

                if (i.DayOfWeek.ToString() == "Saturday" || i.DayOfWeek.ToString() == "Sunday")
                {                    
                    continue;
                }

                else if (holidays.Any(x => x.Month == i.Month && x.Day == i.Day))
                {
                    continue;
                }

                workDaysCounter++;
            }

            Console.WriteLine(workDaysCounter);
        }
    }
}
