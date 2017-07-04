using System.Collections.Generic;
using System.Linq;

namespace _03.OldestFamilyMember
{
    class Family
    {
        public List<Person> people;

        public List<Person> People {
            get { return this.people; }
            set { this.people = new List<Person>(); }
        }

        public void AddMember(Person member)
        {
            this.people.Add(member);
        }

        public Person GetOldestMember()
        {
            return people.OrderByDescending(p => p.Age).First();
        }
    }
}
