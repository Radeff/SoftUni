using System;

namespace _12.CharacterMultiplier
{
    public class CharacterMultiplier
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split();
            var first = input[0].ToCharArray();
            var second = input[1].ToCharArray();
            var shorter = first.Length;
            var longer = second.Length;
            var diff = Math.Abs(first.Length - second.Length);

            if (first.Length > second.Length)
            {
                shorter = second.Length;
                longer = first.Length;
            }

            var sum = 0;

            for (int i = 0; i < shorter; i++)
            {
                sum += first[i] * second[i];
            }

            if (diff != 0)
            {
                for (int i = longer - diff; i < longer; i++)
                {
                    if (longer == first.Length)
                    {
                        sum += first[i];
                    }
                    else
                    {
                        sum += second[i];
                    }
                }
            }

            Console.WriteLine(sum);
        }
    }
}
