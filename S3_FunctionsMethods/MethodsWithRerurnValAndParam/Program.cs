using System;

namespace MethodsWithRerurnValAndParam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int result = Add(10, 25);
            //Console.WriteLine(result);
            Console.WriteLine(Add(5,10));
            Console.WriteLine(Add(Add(10,10),Add(20,20)));

            Console.WriteLine(Multiply(5,5));
            Console.WriteLine(Divide(20,7));

            Console.Read();
        }
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public static int Multiply(int num1, int num2)
        {
            return (num1 * num2);
        }

        public static double Divide(double num1, double num2)
        {
            return num1/num2;
        }
    }
}
