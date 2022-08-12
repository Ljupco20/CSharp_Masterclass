using System;

namespace ChallengeMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string friend1 = "Ljupco";
            string friend2 = "Marijana";
            string friend3 = "Fico";

            GreetFriend(friend1);
            GreetFriend(friend2);
            GreetFriend(friend3);

            Console.WriteLine("---------------------------------------------");

            GreetFriend2(friend1, friend2, friend3);

            Console.Read();
        }
        public static void GreetFriend( string friendName)
        {
            Console.WriteLine($"Hi {friendName}, my friend!");
        }
        public static void GreetFriend2(string friendName1, string friendName2, string friendName3)
        {
            Console.WriteLine($"Hi {friendName1}, my friend!");
            Console.WriteLine($"Hi {friendName2}, my friend!");
            Console.WriteLine($"Hi {friendName3}, my friend!");
        }
    }
}
