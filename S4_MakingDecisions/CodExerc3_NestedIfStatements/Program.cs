using System;

namespace CodExerc3_NestedIfStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NestedCheck(28);
            NestedCheck(3);
            NestedCheck(7);
            NestedCheck(1);
            NestedCheck(21);

        }
        public static void NestedCheck(int number)
        {
            if (number % 3 == 0)
            {
                Console.WriteLine("Divisible by 3.");
            }
            else if (number % 7 == 0)
            {
                Console.WriteLine("Divisible by 7.");
            }
            else
            {
                if (number % 2 != 0)
                {
                    Console.WriteLine("Odd number.");
                }
                else
                {
                    Console.WriteLine("Even number.");
                }
            }
        }
    }
}
