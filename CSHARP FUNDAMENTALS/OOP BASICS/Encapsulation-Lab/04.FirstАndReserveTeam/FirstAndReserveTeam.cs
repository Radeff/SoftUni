using System;

namespace _04.FirstAndReserveTeam
{
    public class FirstAndReserveTeam
    {
        public static void Main()
        {
            var lines = int.Parse(Console.ReadLine());
            var team = new Team("PFC Dunav Ruse");
            for (int i = 0; i < lines; i++)
            {
                try
                {
                    var cmdArgs = Console.ReadLine().Split();
                    var person = new Person(cmdArgs[0],
                        cmdArgs[1],
                        int.Parse(cmdArgs[2]),
                        double.Parse(cmdArgs[3]));

                    team.AddPlayer(person);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            Console.WriteLine($"First team have {team.FirstTeam.Count} players");
            Console.WriteLine($"Reserve team have {team.ReserveTeam.Count} players");
        }
    }
}
