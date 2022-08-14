using System;

namespace IntroductionToMakingDecisions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's the temperature like?");
            string temperature = Console.ReadLine();
            int numTemp;
            int number;

            if(int.TryParse(temperature, out number))
            {
                numTemp = number;
            }
            else
            {
                numTemp = 0;
                Console.WriteLine("Value entered was not a number, 0 set as temperature");
            }


            if (numTemp < 20)
            {
                Console.WriteLine("Take a coat");
            }
            else if (numTemp== 20)
            {
                Console.WriteLine("Pants and pull over should be fine");
            }
            else if (numTemp > 30)
            {
                Console.WriteLine("It's super hot!");
            }
            else
            {
                Console.WriteLine("Shorts are enough today");
            }
            Console.ReadKey();
        }
    }
}
