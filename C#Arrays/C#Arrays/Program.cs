namespace C_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // array = a variable that can store multiple values. fixed size.

            String[] cars = new String[3];

            //String[] cars = { "Honda", "Toyota", "GR GT" };

            cars[0] = "Honda";
            cars[1] = "Toyota";
            cars[2] = "GR GT";

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }



            Console.ReadKey();
        }
    }
}
