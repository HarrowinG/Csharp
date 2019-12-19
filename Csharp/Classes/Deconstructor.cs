namespace Csharp.Classes
{
    public class Deconstructor
    {
        public readonly int Age;
        public readonly int Mass;

        public Deconstructor(int age, int mass)
        {
            Age = age;
            Mass = mass;
        }

        public void Deconstruct(out int age, out int mass)
        {
            age = Age;
            mass = Mass;
        }

        public static void Run()
        {
            var obj = new Deconstructor(24, 65);
            //all methods are the same, need to be named Deconstruct to be used as deconstruct assignment operator
            (int age, int mass) = obj;

            (var age2, var mass2) = obj;

            var (age3, mass3) = obj;

            int age4, mass4;
            (age4, mass4) = obj;

            int age5, mass5;
            obj.Deconstruct(out age5, out mass5);

            obj.Deconstruct(out int age6, out int mass6);

            obj.Deconstruct(out var age7, out var mass7);

            int age8, mass8;
            obj.DeconstructExtension(out age8, out mass8);

            obj.DeconstructExtension(out int age9, out int mass9);

            obj.DeconstructExtension(out var age10, out var mass10);
        }
    }

    public static class DeconstructorExtensions
    {
        public static void DeconstructExtension(this Deconstructor obj, out int age, out int mass)
        {
            age = obj.Age;
            mass = obj.Mass;
        }
    }
}
