namespace C_Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // constructor = A special method in a class
            //               Same name as the class name
            //               Can be used to assign arguments to fields when creating an object

            Car car1 = new Car("Toyota", "GR GT", 2027, "Red");
            Car car2 = new Car("Toyota", "Supra MK5", 2023, "Blue");

            car1.Drive();
            car2.Drive();

            Console.ReadKey();
        }
    }
}
