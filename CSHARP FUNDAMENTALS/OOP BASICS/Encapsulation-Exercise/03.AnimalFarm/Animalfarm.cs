﻿namespace P03_AnimalFarm
{
    using System;
    using System.Diagnostics;
    using System.Linq;
    using System.Reflection;
    using AnimalFarm.Models;

    public class Animalfarm
    {
        public static void Main()
        {
            Type chickenType = typeof(Chicken);
            FieldInfo[] fields = chickenType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            MethodInfo[] methods = chickenType.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);
            Debug.Assert(fields.Where(f => f.IsPrivate).Count() == 2);
            Debug.Assert(methods.Where(m => m.IsPrivate).Count() == 1);

            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            Chicken chicken = null;

            try
            {
                chicken = new Chicken(name, age);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }

            Console.WriteLine(
                "Chicken {0} (age {1}) can produce {2} eggs per day.",
                chicken.Name,
                chicken.Age,
                chicken.GetProductPerDay());
        }
    }
}
