using System;

namespace Challenge_IfStatements
{
    internal class Program
    {
        static string userName;
        static string password;
        static void Main(string[] args)
        {
            Register();
            Login();
            Console.Read();
        }

        public static void Register()
        {
            Console.WriteLine("Registration - Please enter a username");
             userName = Console.ReadLine();
            
            Console.WriteLine("Registration - Please enter a password");
            password = Console.ReadLine();
            Console.WriteLine("Registration completed");
            Console.WriteLine("-----------------------------------------------------------");


        }
        public static void  Login()
        {
            Console.WriteLine("Please enter your username");
            if (userName  == Console.ReadLine())
            {
                Console.WriteLine("Please enter your password");
                if (password == Console.ReadLine())
                {
                    Console.WriteLine("You successfully logged in");
                }
                else
                {
                    Console.WriteLine("Login failed, wrong password, restart the program");
                }
            }
            else
            {
                Console.WriteLine("Login failed, wrong username, restart the program");
            }

        }

    }
}
