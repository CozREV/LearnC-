namespace C_Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // object = An instance of a class
            //          A class can be used as a blueprint to create objects (OOP)
            //          objects can have fields & methods (characteristics & actions)

            Human human1 = new Human();
            Human human2 = new Human();

            human1.name = "Sparky";
            human1.age = 33;

            human2.name = "Spritle";
            human2.age = 12;

            human1.eat();
            human1.sleep();
            human1.yearsOld();

            Console.WriteLine();

            human2.eat();
            human2.sleep();
            human2.yearsOld();

            Console.ReadKey();
        }
    }
}
