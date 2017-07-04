using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.CarSalesman
{
    public class CarSalesman
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var engines = new Stack<Engine>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                engines.Push(new Engine(input[0], int.Parse(input[1])));

                if (input.Length > 2)
                {
                    int displacement;
                    var isDigit = int.TryParse(input[2], out displacement);

                    if (isDigit)
                    {
                        engines.Peek().Displacement = displacement;
                    }
                    else
                    {
                        engines.Peek().Efficiency = input[2];
                    }

                    if (input.Length > 3)
                    {
                        if (isDigit)
                        {
                            engines.Peek().Efficiency = input[3];
                        }
                        else
                        {
                            engines.Peek().Displacement = int.Parse(input[3]);
                        }
                    }
                }
            }

            n = int.Parse(Console.ReadLine());
            var cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                var car = new Car(
                    input[0],
                    engines.First(e => e.Model == input[1])
                    );

                if (input.Length > 2)
                {
                    int weight;
                    var isDigit = int.TryParse(input[2], out weight);

                    if (isDigit)
                    {
                        car.Weight = weight;
                    }
                    else
                    {
                        car.Color = input[2];
                    }

                    if (input.Length > 3)
                    {
                        if (isDigit)
                        {
                            car.Color = input[3];
                        }
                        else
                        {
                            car.Weight = int.Parse(input[3]);
                        }
                    }
                }

                cars.Add(car);
            }

            foreach (var car in cars)
            {
                Console.Write(car.ToString());
            }
        }
    }
}
