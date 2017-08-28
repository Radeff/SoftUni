using System;

public class ShowCar : Car
{
    public ShowCar(string brand, string model, int yearOfProduction, int horsepower, int accelleration, int suspension, int durability)
        : base(brand, model, yearOfProduction, horsepower, accelleration, suspension, durability)
    {
        this.Stars = 0;
    }

    public override string ToString()
    {
        var result = base.ToString();
        return string.Concat(result, Environment.NewLine, $"{this.Stars} *");
    }
}
