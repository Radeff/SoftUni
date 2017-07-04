using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.RawData
{
    public class RawData
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                var model = input[0];
                var engine = new Engine(int.Parse(input[1]), int.Parse(input[2]));
                var cargo = new Cargo(int.Parse(input[3]), input[4]);

                var tires = new Tire[]{
                    new Tire(int.Parse(input[6]), double.Parse(input[5])),
                    new Tire(int.Parse(input[8]), double.Parse(input[7])),
                    new Tire(int.Parse(input[10]), double.Parse(input[9])),
                    new Tire(int.Parse(input[12]), double.Parse(input[11])),
                };

                var car = new Car(
                    model,
                    engine,
                    cargo,
                    tires
                );

                cars.Add(car);
            }

            var command = Console.ReadLine();

            if (command == "fragile")
            {
                foreach (var car in cars.Where(c => c.Cargo.Type == "fragile" && c.Tires
                                .FirstOrDefault(t => t.Pressure < 1) != null))
                {
                    Console.WriteLine($"{car.Model}");
                }
            }

            if (command == "flamable")
            {
                foreach (var car in cars.Where(c => c.Cargo.Type == "flamable" && c.Engine.Power > 250))
                {
                    Console.WriteLine($"{car.Model}");
                }
            }
        }
    }
}
