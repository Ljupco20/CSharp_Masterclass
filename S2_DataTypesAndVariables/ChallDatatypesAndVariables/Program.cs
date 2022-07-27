using System;

namespace ChallDatatypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte myByte = 3;
            Console.WriteLine(myByte);

            sbyte mySbyte = -3;
            Console.WriteLine(mySbyte);

            int myInt = -1000000;
            Console.WriteLine(myInt);

            uint myUint = 123091;
            Console.WriteLine(myUint);

            short myShort = -32768;
            Console.WriteLine(myShort);

            ushort myUShort = 65535;
            Console.WriteLine(myUShort);

            long myLong = -50000000;
            Console.WriteLine(myLong);

            ulong myULong = 50000000000;
            Console.WriteLine(myULong);

            float myFloat = -32.1289f;
            Console.WriteLine(myFloat);

            decimal myDecimal = 2.5M;

            double myDouble = -12.1231250;
            Console.WriteLine(myDouble);

            char myChar = 'L';
            Console.WriteLine(myChar);

            bool myBool = true;
            Console.WriteLine(myBool);

            string myString = "I control text";
            Console.WriteLine(myString);

            string numText = "15";
            Console.WriteLine(numText);

            int myNumFromText = int.Parse(numText);
            Console.WriteLine(myNumFromText);
            Console.ReadLine();
        }
    }
}
