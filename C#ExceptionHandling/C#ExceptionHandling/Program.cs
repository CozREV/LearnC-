namespace C_ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // exception = errors that occur during execution

            //        try     = try some code that is considered "dangerous"
            //        catch   = catches and handles exceptions when they occur
            //        finally = always executes regardless if exception is caught or not

            int a;
            int b;
            double total;
            
            try
            {
                Console.Write("Enter number 1: ");
                a = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter number 2: ");
                b = Convert.ToInt32(Console.ReadLine());

                total = a / b;
                Console.WriteLine("Result:" + total);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Numbers only!");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Cannot divide by 0");
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong");
            }
            finally
            {
                Console.WriteLine("Thanks for testing!");
            }


            Console.ReadKey();
        }
    }
}
