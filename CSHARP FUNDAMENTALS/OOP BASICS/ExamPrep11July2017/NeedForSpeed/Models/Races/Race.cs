using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class Race
{
    protected Race(int length, string route, int prizingPool)
    {
        Length = length;
        Route = route;
        PrizingPool = prizingPool;
        Participants = new List<Car>();
    }

    public int Length { get; }

    public string Route { get; }

    public int PrizingPool { get; }

    public virtual int GoldTime { get; }
    public virtual int Laps { get; }

    public List<Car> Participants { get; protected internal set; }

    public string CalculateResult()
    {
        var sb = new StringBuilder();
        if (this.GetType().Name == nameof(CircuitRace))
        {
            sb.AppendLine($"{this.Route} - {this.Length * this.Laps}");
        }
        else
        {
            sb.AppendLine($"{this.Route} - {this.Length}");
        }
        
        List<Car> orderedParticipants = null;

        switch (this.GetType().Name)
        {
            case nameof(CasualRace):
                orderedParticipants = this.Participants.OrderByDescending(p => p.OverallPerformance).Take(3).ToList();

                if (orderedParticipants.Count == 0)
                {
                    return "Cannot start the race with zero participants.";
                }
                else
                {
                    sb.AppendLine($"1. {orderedParticipants[0].Brand} {orderedParticipants[0].Model} {orderedParticipants[0].OverallPerformance}PP - ${this.PrizingPool * 50 / 100}");
                    if (orderedParticipants.Count > 1)
                    {
                        sb.AppendLine($"2. {orderedParticipants[1].Brand} {orderedParticipants[1].Model} {orderedParticipants[1].OverallPerformance}PP - ${this.PrizingPool * 30 / 100}");
                    }
                    if (orderedParticipants.Count > 2)
                    {
                        sb.AppendLine($"3. {orderedParticipants[2].Brand} {orderedParticipants[2].Model} {orderedParticipants[2].OverallPerformance}PP - ${this.PrizingPool * 20 / 100}");
                    }

                    this.Participants = new List<Car>();
                }

                break;

            case nameof(DragRace):
                orderedParticipants = this.Participants.OrderByDescending(p => p.EnginePerformance).Take(3).ToList();

                if (orderedParticipants.Count == 0)
                {
                    return "Cannot start the race with zero participants.";
                }
                else
                {
                    sb.AppendLine($"1. {orderedParticipants[0].Brand} {orderedParticipants[0].Model} {orderedParticipants[0].EnginePerformance}PP - ${this.PrizingPool * 50 / 100}");
                    if (orderedParticipants.Count > 1)
                    {
                        sb.AppendLine($"2. {orderedParticipants[1].Brand} {orderedParticipants[1].Model} {orderedParticipants[1].EnginePerformance}PP - ${this.PrizingPool * 30 / 100}");
                    }
                    if (orderedParticipants.Count > 2)
                    {
                        sb.AppendLine($"3. {orderedParticipants[2].Brand} {orderedParticipants[2].Model} {orderedParticipants[2].EnginePerformance}PP - ${this.PrizingPool * 20 / 100}");
                    }

                    this.Participants = new List<Car>();
                }

                break;

            case nameof(DriftRace):
                orderedParticipants = this.Participants.OrderByDescending(p => p.SuspensionPerformance).Take(3).ToList();

                if (orderedParticipants.Count == 0)
                {
                    return "Cannot start the race with zero participants.";
                }
                else
                {
                    sb.AppendLine($"1. {orderedParticipants[0].Brand} {orderedParticipants[0].Model} {orderedParticipants[0].SuspensionPerformance}PP - ${this.PrizingPool * 50 / 100}");
                    if (orderedParticipants.Count > 1)
                    {
                        sb.AppendLine($"2. {orderedParticipants[1].Brand} {orderedParticipants[1].Model} {orderedParticipants[1].SuspensionPerformance}PP - ${this.PrizingPool * 30 / 100}");
                    }
                    if (orderedParticipants.Count > 2)
                    {
                        sb.AppendLine($"3. {orderedParticipants[2].Brand} {orderedParticipants[2].Model} {orderedParticipants[2].SuspensionPerformance}PP - ${this.PrizingPool * 20 / 100}");
                    }

                    this.Participants = new List<Car>();
                }

                break;

            case nameof(TimeLimitRace):
                if (this.Participants.Count == 0)
                {
                    return "Cannot start the race with zero participants.";
                }

                var timePerformance = this.Participants[0].TimePerformance * this.Length;
                var moneyEarned = 0;
                var medal = string.Empty;

                if (timePerformance <= this.GoldTime)
                {
                    moneyEarned = this.PrizingPool;
                    medal = "Gold";
                }
                else if (timePerformance <= this.GoldTime + 15)
                {
                    moneyEarned = this.PrizingPool / 2;
                    medal = "Silver";
                }
                else if (timePerformance > this.GoldTime + 15)
                {
                    moneyEarned = this.PrizingPool * 30 / 100;
                    medal = "Bronze";
                }

                sb.AppendLine($"{this.Participants[0].Brand} {this.Participants[0].Model} - {timePerformance} s.");
                sb.AppendLine($"{medal} Time, ${moneyEarned}.");
                this.Participants.RemoveAt(0);

                break;

            case nameof(CircuitRace):

                if (this.Participants.Count == 0)
                {
                    return "Cannot start the race with zero participants.";
                }
                else
                {
                    for (int i = 0; i < this.Laps; i++)
                    {
                        for (int j = 0; j < this.Participants.Count; j++)
                        {
                            this.Participants[i].Durability -= this.Length * this.Length;
                        }
                    }

                    orderedParticipants = this.Participants.OrderByDescending(p => p.OverallPerformance).Take(4).ToList();

                    sb.AppendLine($"1. {orderedParticipants[0].Brand} {orderedParticipants[0].Model} {orderedParticipants[0].OverallPerformance}PP - ${this.PrizingPool * 40 / 100}");
                    if (orderedParticipants.Count > 1)
                    {
                        sb.AppendLine($"2. {orderedParticipants[1].Brand} {orderedParticipants[1].Model} {orderedParticipants[1].OverallPerformance}PP - ${this.PrizingPool * 30 / 100}");
                    }
                    if (orderedParticipants.Count > 2)
                    {
                        sb.AppendLine($"3. {orderedParticipants[2].Brand} {orderedParticipants[2].Model} {orderedParticipants[2].OverallPerformance}PP - ${this.PrizingPool * 20 / 100}");
                    }
                    if (orderedParticipants.Count > 3)
                    {
                        sb.AppendLine($"4. {orderedParticipants[3].Brand} {orderedParticipants[3].Model} {orderedParticipants[3].OverallPerformance}PP - ${this.PrizingPool * 10 / 100}");
                    }

                    this.Participants = new List<Car>();
                }
                

                break;
        }

        return sb.ToString().Trim();
    }
}