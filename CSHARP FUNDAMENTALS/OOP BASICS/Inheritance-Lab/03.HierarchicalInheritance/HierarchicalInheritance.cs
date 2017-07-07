namespace _03.HierarchicalInheritance
{
    public class HierarchicalInheritance
    {
        public static void Main()
        {
            var dog = new Dog();
            dog.Eat();
            dog.Bark();

            var cat = new Cat();
            cat.Eat();
            cat.Meow();
        }
    }
}
