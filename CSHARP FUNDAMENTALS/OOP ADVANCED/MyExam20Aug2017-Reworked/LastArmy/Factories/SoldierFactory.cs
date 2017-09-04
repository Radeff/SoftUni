using System;

public class SoldierFactory : ISoldierFactory
{
    public ISoldier CreateSoldier(string soldierTypeName, string name, int age, double experience, double endurance)
    {
        var type = Type.GetType(soldierTypeName);
        var instance = (ISoldier)Activator.CreateInstance(type, new object[] {name, age, experience, endurance});
        return instance;
    }
}
