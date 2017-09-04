using System;

public class MissionFactory : IMissionFactory
{
    public IMission CreateMission(string difficultyLevel, double neededPoints)
    {
        var type = Type.GetType(difficultyLevel);
        var instance = (IMission)Activator.CreateInstance(type, new object[] {neededPoints});
        
        return instance;
    }
}
