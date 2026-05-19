namespace C_MultidimensionalArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] Toyota = { "GR Supra", "GR Yaris", "GR Corolla" };
            String[] Honda = { "Civic", "S2000", "NSX" };
            String[] Bugatti = { "Tourbillon", "Veyron", "Chiron" };

            String[,] parkingLot = {
                                     { "GR Supra", "GR Yaris", "GR Corolla" },
                                     { "Civic", "S2000", "NSX" },
                                     { "Tourbillon", "Veyron", "Chiron" }
                                   };

            parkingLot[0, 2] = "GR86";
            parkingLot[2, 1] = "EB110";


            for (int i = 0; i < parkingLot.GetLength(0); i++)
            {
                for (int j = 0; j < parkingLot.GetLength(1); j++)
                {
                    Console.WriteLine(parkingLot[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }

}
