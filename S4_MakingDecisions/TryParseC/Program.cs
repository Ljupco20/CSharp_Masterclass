using System;

namespace TryParseC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numberAsString = "128";
            float parsedValue;

            bool success = float.TryParse(numberAsString, out parsedValue);
            if (success)
            {
                Console.WriteLine($"Parsing successful - number is {parsedValue}");
            }
            else
            {
                Console.WriteLine($"Parsing failed");
            }
        }
    }
}
