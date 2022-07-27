using System;

namespace ImplicitAndExplicitConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //implicit conversion ------------------------------------------
            int num = 12390532;
            long bigNum = num;

            float myFloat = 13.37F;
            double myNewDouble = myFloat;



            double myDouble = 13.37;
            int myInt;

            //explicit conversion ------------------------------------------

            //cast double to int
            myInt = (int)myDouble;

            //typeConversion -----------------------------------------------
            string myString = myDouble.ToString(); //"13.37"
            num.ToString();

            string myFloatString = myFloat.ToString();
            bool sunIsShining = true;

            string myBoolString = sunIsShining.ToString();  

            Console.WriteLine(myInt);
            Console.WriteLine(myString);
            Console.WriteLine(myFloatString);
            Console.WriteLine(myBoolString);
            Console.Read();

        }
    }
}
