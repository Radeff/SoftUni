using System.Collections.Generic;
using System.Linq;

namespace StartUp
{
    public class Person
    {
        private string name;
        private int age;
        private List<BankAccount> accounts;

        public Person(string name, int age) : this(name, age, new List<BankAccount>())
        {
        }

        public Person(string name, int age, List<BankAccount> accounts)
        {
            this.name = name;
            this.age = age;
            this.accounts = accounts;
        }

        public double GetBalance()
        {
            return this.accounts.Sum(p => p.Balance);
        }
    }
}