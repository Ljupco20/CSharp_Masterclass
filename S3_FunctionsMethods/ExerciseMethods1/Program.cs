using System;

namespace ExerciseMethods1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // We encourage you to test your code with different strings,
            // but don't forget to put the default string back at the end of your testing.
            string s = "HeY ThErE !";

            /// Change nothing down here 
            s = LowUpper(s);
            Console.WriteLine(s);
            Count(s);
        }
        public static string LowUpper(string s)
        {

            return s.ToLower() + s.ToUpper();
        }
        public static void Count (string s)
        {
            Console.WriteLine($"The string contains {s.Length} characters");
        }
    }
}
