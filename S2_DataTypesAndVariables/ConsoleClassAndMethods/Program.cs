using System;

namespace ConsoleClassAndMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string and press enter:");
            string readInput = Console.ReadLine();
            Console.WriteLine("Yuo have entered {0}", readInput);

            Console.WriteLine("Enter a key and press enter:");
            int asciiValue = Console.Read();
            Console.WriteLine("ASCII value is {0}", asciiValue);
            Console.ReadKey();
        }
    }
}
