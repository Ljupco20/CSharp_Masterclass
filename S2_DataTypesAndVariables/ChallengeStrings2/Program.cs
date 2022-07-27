using System;

namespace ChallengeStrings2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string here: ");
            //Read first input string
            string input = Console.ReadLine();

            Console.WriteLine("Enter the character to search: ");
            //Read character input to search
            char searcInput = Console.ReadLine()[0];

            //Gets the index of character from the string
            int seachIndex = input.IndexOf(searcInput);

            //Prints the Index as a search result on console
            Console.WriteLine($"Index of character {searcInput} in string is {seachIndex}");

            Console.Write("Enter your first name: ");
            //Read the first name
            string firstName =  Console.ReadLine();
            Console.Write("Enter your last name: ");
            //Read the last name
            string lastName = Console.ReadLine();


            //Concat
            string fullName = string.Concat(firstName," ", lastName);
            Console.WriteLine($"Your full name is {fullName}");
            Console.ReadKey();
        }
    }
}
