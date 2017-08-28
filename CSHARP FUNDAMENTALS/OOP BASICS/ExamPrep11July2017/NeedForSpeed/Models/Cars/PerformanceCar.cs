using System;
using System.Collections.Generic;

public class PerformanceCar : Car
{
    public PerformanceCar(string brand, string model, int yearOfProduction, int horsepower, int accelleration, int suspension, int durability)
        : base(brand, model, yearOfProduction, horsepower, accelleration, suspension, durability)
    {
        this.AddOns = new List<string>();
        this.Horsepower += this.Horsepower * 50 / 100;
        this.Suspension -= this.Suspension * 25 / 100;
    }

    public override string ToString()
    {
        var result = base.ToString();
        var addons = this.AddOns.Count == 0 ? "None" : string.Join(", ", this.AddOns);
        return string.Concat(result, Environment.NewLine, $"Add-ons: {addons}");
    }
}
