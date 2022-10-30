﻿namespace MultidimensionaArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] ford = { "Mustang", "F-150", "'Explorer" };
            String[] chevy = { "Corvete", "Camaro", "Silverado" };
            String[] toyota = { "'Corola", "Camry", "Rav4" };

            String[,] parkingLot =
            {
                { "Mustang", "F-150", "'Explorer" },
                { "Corvete", "Camaro", "Silverado" },
                { "'Corola", "Camry", "Rav4" }
            };
            parkingLot[0, 2] = "Fusion";
            parkingLot[2, 0] = "Tacoma";
            /*
            foreach (String car in parkingLot)
            {
                Console.WriteLine(car);
            }
            */
            for (int i = 0; i < parkingLot.GetLength(0); i++)
            {
                for (int j = 0; j < parkingLot.GetLength(1); j++)
                {
                    Console.Write(parkingLot[i,j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}