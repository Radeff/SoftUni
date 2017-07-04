using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.SpeedRacing
{
    public class SpeedRacing
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                var model = input[0];
                var fuelAmount = double.Parse(input[1]);
                var fuelConsumption = double.Parse(input[2]);

                var car = new Car(
                    model,
                    fuelAmount,
                    fuelConsumption
                );

                cars.Add(car);
            }

            var command = Console.ReadLine().Split();

            while (command[0] != "End")
            {
                var model = command[1];
                var car = cars.Where(c => c.Model == model).First();

                if (car != null)
                {
                    car.Drive(double.Parse(command[2]));
                }

                command = Console.ReadLine().Split();
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.DistanceTravelled}");
            }
        }
    }
}
