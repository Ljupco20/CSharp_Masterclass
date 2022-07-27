using System;

namespace StringManipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //define few vaiables
            int age = 36;
            string name = "Ljupco";
            string job = "programmer";
            // 1. String concatination
            Console.WriteLine("String concatination");
            Console.WriteLine("Hello my name is " + name + " I'm " + age + " years old");

            // 2. String formating
            Console.WriteLine("String formating");
            Console.WriteLine("Hello my name is {0}, I am {1} years old and I'm a {2}", name, age, job);

            // 3. String interpolation
            Console.WriteLine("String interpolation");
            Console.WriteLine($"Hello my name is {name}, I am {age} years old and I'm a {job}");

            // 3. Verbatim string 
            Console.WriteLine("Verbatim string ");
            Console.WriteLine(@"D:\REPOSITORIES\CSharp_Masterclass\S2_DataTypesAndVariables");

            string firstName = "Ljupco";
            string lastName = "Trajanovski";
            string fullName = string.Concat(" ", firstName, lastName, " ");
            Console.WriteLine(firstName.Substring(2));
            Console.WriteLine(firstName.ToLower());
            Console.WriteLine(firstName.ToUpper());
            Console.WriteLine(fullName.Trim());
            Console.WriteLine(firstName.IndexOf('j'));
            Console.WriteLine(String.IsNullOrWhiteSpace(firstName));
            Console.ReadKey();
        }
    }
}
