namespace _02.SalaryIncrease
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private double salary;

        public Person(string firstName, string lastName, int age, double salary)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.salary = salary;
        }

        public string FirstName
        {
            get { return this.firstName; }
        }

        public string LastName
        {
            get { return this.lastName; }
        }

        public int Age
        {
            get { return this.age; }
        }

        public double Salary
        {
            get { return this.salary; }
        }

        public void IncreaseSalary(double bonus)
        {
            if (this.age > 30)
            {
                this.salary += this.salary * bonus / 100.0;
            }
            else
            {
                this.salary += this.salary * (bonus / 100.0) / 2.0;
            }
        }
        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} get {this.Salary:F2} leva";
        }
    }
}