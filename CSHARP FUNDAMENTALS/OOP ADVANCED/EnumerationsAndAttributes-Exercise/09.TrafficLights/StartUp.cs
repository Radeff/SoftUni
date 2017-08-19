using System;
using System.Text;

namespace _09.TrafficLights
{
    public class StartUp
    {
        public static void Main()
        {
            var inputColors = Console.ReadLine().Split();

            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var sb = new StringBuilder();
                var current = 0;
                for (int j = 0; j < inputColors.Length; j++)
                {
                    current = (int)Enum.Parse(typeof(LightColor), inputColors[j]) + 1;

                    if (current > 2)
                    {
                        current = 0;
                    }
                    
                    inputColors[j] = Enum.GetName(typeof(LightColor), current);
                    sb.Append(Enum.GetName(typeof(LightColor), current));
                    sb.Append(" ");
                    
                }
                Console.WriteLine(sb);
            }
        }
    }
}
