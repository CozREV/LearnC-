namespace C_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // method  = performs a section of code, whenever it's called "invoked".
            //           benefit = Let's us reuse code w/o writing it multiple times
            //           Good practice is to capitalize method names

            String name = "REV";
            int age = 22;

            singHappyBirthday(name, age); 

            Console.ReadKey();



        }
        static void singHappyBirthday(String birthdayBoy, int yearsOld)
        {
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine("Happy birthday dear " + birthdayBoy);
            Console.WriteLine("You are " + yearsOld + " years old!");
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine();
        }
    }
}
