using System;
using System.Linq;

namespace _02.Ladybugs
{
    public class Ladybugs
    {
        public static void Main()
        {
            var fieldSize = int.Parse(Console.ReadLine());
            var ladybugs = Console.ReadLine()
                .Split(" \t".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var field = new int[fieldSize];

            for (int i = 0; i < fieldSize; i++)
            {
                if (ladybugs.Contains(i))
                {
                    field[i] = 1;
                    continue;
                }

                field[i] = 0;
            }

            while (true)
            {
                var input = Console.ReadLine()
                    .Split()
                    .ToArray();

                if (input[0] == "end")
                {
                    break;
                }

                var bugIndex = int.Parse(input[0]);
                var direction = input[1];
                var flyLength = int.Parse(input[2]);
                long landingIndex = bugIndex + flyLength;

                if (direction == "left")
                {
                    landingIndex = bugIndex - flyLength;
                }

                if (bugIndex < fieldSize && 
                    bugIndex >= 0 && 
                    field[bugIndex] == 1 && 
                    flyLength != 0)
                {
                    if (direction == "right")
                    {
                        for (long i = landingIndex; i < fieldSize; i += flyLength)
                        {
                            if (field[i] != 1)
                            {
                                field[i] = 1;
                                break;
                            }
                        }

                        field[bugIndex] = 0;
                    }

                    else
                    {
                        for (long i = landingIndex; i >= 0; i--)
                        {
                            if (field[i] != 1)
                            {
                                field[i] = 1;
                                break;
                            }
                        }

                        field[bugIndex] = 0;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", field));
        }
    }
}
