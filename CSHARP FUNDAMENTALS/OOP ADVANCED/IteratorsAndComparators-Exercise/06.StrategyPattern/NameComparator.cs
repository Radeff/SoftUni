using System.Collections.Generic;

namespace _06.StrategyPattern
{
    public class NameComparator : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            if (x.Name.Length != y.Name.Length)
            {
                return x.Name.Length - y.Name.Length;
            }

            var first = x.Name[0].ToString().ToLower();
            var second = y.Name[0].ToString().ToLower();

            return first.CompareTo(second);
        }
    }
}