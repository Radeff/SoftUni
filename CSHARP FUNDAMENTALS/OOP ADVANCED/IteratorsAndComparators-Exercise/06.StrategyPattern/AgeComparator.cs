using System.Collections.Generic;

namespace _06.StrategyPattern
{
    public class AgeComparator : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            var result = x.Age - y.Age;

            return result;
        }
    }
}