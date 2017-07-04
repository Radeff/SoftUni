namespace _01.DefineClassPerson
{
    public class Person
    {
        public string name;
        public int age;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public Person(string name)
        {
            this.name = name;
        }

        public Person(string name, int age) : this(name)
        {
            this.age = age;
        }
    }
}