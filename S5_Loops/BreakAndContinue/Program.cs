using System;

namespace BreakAndContinue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("break");
            for (int counter = 0; counter < 10; counter++)
            {
                Console.WriteLine(counter);
                if (counter ==3)
                {
                    Console.WriteLine("At 3 we stop");
                    break;
                }
            }
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("continue");
            for (int counter = 0; counter < 10; counter++)
            {
               
                if (counter == 3)
                {
                    Console.WriteLine("We skip 3 with --- continue ---");
                    continue;
                }
                else
                {
                    Console.WriteLine(counter);
                }
            }
            Console.Read();
        }
    }
}
