﻿using System.Collections.Generic;

public class Ranker : Soldier
{
    private const double OverallSkillMultiplier = 1.5;

    private readonly List<string> weaponsAllowed = new List<string>
    {
        nameof(Gun),
        nameof(AutomaticMachine),
        nameof(Helmet)
    };

    public Ranker(string name, int age, double experience, double endurance) 
        : base(name, age, experience, endurance)
    {
    }

    public override double OverallSkill => (this.Age + this.Experience) * OverallSkillMultiplier;

    protected override IReadOnlyList<string> WeaponsAllowed => this.weaponsAllowed;
}
