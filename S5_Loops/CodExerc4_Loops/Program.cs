using System;

namespace CodExerc4_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For Loop");
            for (int i = -3; i < 4; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("While Loop");
            int j = 3;
            while (j > -4)
            {
                Console.WriteLine(j--);
            }
        }
    }
}
