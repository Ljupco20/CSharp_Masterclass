using System;

namespace WhileLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int counter = 0;
            string enteredtext = "";

            while (enteredtext.Equals(""))
            {
                Console.WriteLine("Please enter enter to increase amount by one, anything else if you want to finish counting");
                enteredtext = Console.ReadLine();

                counter++;
                Console.WriteLine($"Current people count {counter}");
            }

            Console.WriteLine($"{counter} people are inside in the bus. Press enter to close the program");
            Console.Read();
           
        }
    }
}
