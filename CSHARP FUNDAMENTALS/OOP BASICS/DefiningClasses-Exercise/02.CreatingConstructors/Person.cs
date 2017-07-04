namespace _02.CreatingConstructors
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

        public Person()
        {
            this.name = "No name";
            this.age = 1;
        }
        public Person(int age) : this()
        {
            this.age = age;
        }

        public Person(string name, int age)
        {
            this.age = age;
            this.name = name;
        }
    }
}