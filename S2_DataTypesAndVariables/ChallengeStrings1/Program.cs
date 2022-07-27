using System;

namespace ChallengeStrings1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myName;
            Console.WriteLine("Please enter your name and press enter");
            myName = Console.ReadLine();

            string myNameToUpper = String.Format("Upper case : {0}", myName.ToUpper());
            string myNameToLower = String.Format("Lower case : {0}", myName.ToLower());
            string myNameTrimmed = String.Format("Trimmed case : {0}", myName.Trim());
            string myNameSubString = String.Format("Substring value : {0}", myName.Substring(1));
            string myNameSubString2 = String.Format("Substring value : {0}", myName.Substring(1, 3));

            Console.WriteLine(myNameToUpper);
            Console.WriteLine(myNameToLower);
            Console.WriteLine(myNameTrimmed);
            Console.WriteLine(myNameSubString);
            Console.WriteLine(myNameSubString2);

            Console.WriteLine("--------------------------------------------------------------");


            Console.WriteLine($"Upper case : { myName.ToUpper()}");
            Console.WriteLine(myName.ToLower());
            Console.WriteLine(myName.Trim());
            Console.WriteLine(myName.Substring(3));
        }
    }
}
