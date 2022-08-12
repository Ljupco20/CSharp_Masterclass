using System;

namespace VoidMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteSomething();
            WriteSomethingSpecific("I am an argument and I'm called from a method");
            Console.Read();
        }

        public static void WriteSomething()
        {
            Console.WriteLine("I'm called from a method");
           
        }

        public static void WriteSomethingSpecific(string myText)
        {
            Console.WriteLine(myText);
            
        }
    }
}
