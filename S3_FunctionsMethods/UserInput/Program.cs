using System;

namespace UserInput
{
    internal class Program
    {
        static void Main(string[] args)
        {         
            Console.WriteLine(Add());     
     
            Console.Read();
        }
        public static int Add()
        {
            Console.WriteLine("Please enter a number");
            string inp1 = Console.ReadLine();     
            int num1 = int.Parse(inp1);


            Console.WriteLine("Please enter another number");
            string inp2 = Console.ReadLine();
            int num2 = int.Parse(inp2);

            return num1 + num2;
        }
    }
}
