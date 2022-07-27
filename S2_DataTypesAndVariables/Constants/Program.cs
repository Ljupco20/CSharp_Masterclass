using System;

namespace Constants
{
    // Constants are imutable values which are known
    // at compile time and do not change for the life of the program.
    internal class Program
    {
        // constants as fields
        const double PI = 3.14159265359;
        const int weeks = 52, months = 12;
        const string birthday = "20.02.1986";
        static void Main(string[] args)
        {
            Console.WriteLine($"My birthday will always be {birthday}");
            Console.ReadKey();
        }
    }
}
