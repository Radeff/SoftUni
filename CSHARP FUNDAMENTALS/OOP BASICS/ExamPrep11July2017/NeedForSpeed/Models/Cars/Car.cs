using System.Collections.Generic;
using System.Text;

public abstract class Car
{
    protected Car(string brand, string model, int yearOfProduction, int horsepower, int accelleration, int suspension, int durability)
    {
        this.Brand = brand;
        this.Model = model;
        this.YearOfProduction = yearOfProduction;
        this.Horsepower = horsepower;
        this.Acceleration = accelleration;
        this.Suspension = suspension;
        this.Durability = durability;
    }

    public string Brand { get; }
    public string Model { get; }
    public int YearOfProduction { get;}
    public int Horsepower { get; protected internal set; }
    public int Acceleration { get; }
    public int Suspension { get; protected internal set; }
    public int Durability { get; protected internal set; }

    public int OverallPerformance => this.Horsepower / this.Acceleration + this.Suspension + this.Durability;
    public int EnginePerformance => this.Horsepower / this.Acceleration;
    public int SuspensionPerformance => this.Suspension + this.Durability;
    public int TimePerformance => this.Horsepower / 100 * this.Acceleration;

    public virtual List<string> AddOns { get; set; }
    public virtual int Stars { get; set; }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"{this.Brand} {this.Model} {this.YearOfProduction}");
        sb.AppendLine($"{this.Horsepower} HP, 100 m/h in {this.Acceleration} s");
        sb.AppendLine($"{this.Suspension} Suspension force, {this.Durability} Durability");
        return sb.ToString().Trim();
    }
}