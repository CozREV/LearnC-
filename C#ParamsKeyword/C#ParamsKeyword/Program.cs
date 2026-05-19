namespace C_ParamsKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //params keyword = a method parameter that takes a variable number of arguments.
            //                 The parameter type must be a single - dimensional array

            double total = checkOut(1, 5, 7, 9, 10, 1);

            Console.WriteLine(total);
            Console.ReadKey();

        }

        static double checkOut(params double[] prices)
        {
            double total = 0;

            foreach (double price in prices)
            {
                total += price;
            }

            return total;
        }
    }
}
