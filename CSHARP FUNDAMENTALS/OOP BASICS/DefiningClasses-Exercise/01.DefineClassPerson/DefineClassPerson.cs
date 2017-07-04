using System;
using System.Reflection;

namespace _01.DefineClassPerson
{
    public class DefineClassPerson
    {
        public static void Main()
        {
            Type personType = typeof(Person);
            FieldInfo[] fields = personType.GetFields(BindingFlags.Public | BindingFlags.Instance);
            Console.WriteLine(fields.Length);
        }
    }
}