using System;
using System.Linq;

public abstract class Bender : Entity
{
    protected Bender(string name, int power)
    {
        this.Name = name;
        this.Power = power;
    }

    public string Name { get; set; }

    public int Power { get; set; }

    public abstract string SpecialtyName { get; }

    public abstract double SpecialtyValue { get; }

    public override string ToString()
    {
        var typeName = this.GetType().Name;
        var type = this.GetType().Name.Remove(typeName.Length - Constants.BenderStringLength);
        var specialtySplitIndex = this.SpecialtyName.IndexOf(this.SpecialtyName.LastOrDefault(Char.IsUpper));
        var specialtyName = this.SpecialtyName.Insert(specialtySplitIndex, " ");

        return $"###{type} {nameof(Bender)}: {this.Name}, {nameof(this.Power)}: {this.Power}, {specialtyName}: {this.SpecialtyValue:F2}";
    }
}