using System;

namespace DoWhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lenghtOfText = 0;
            string wholeText = "";
            do
            {
                Console.WriteLine("Please enter the name of a friend");
                string nameOfFriend = Console.ReadLine();
                int currentLenght = nameOfFriend.Length;
                lenghtOfText += currentLenght;
                wholeText += nameOfFriend;
            } while (lenghtOfText < 20);
            Console.WriteLine($"Thanks that was enough! {wholeText}");
            Console.Read();
        }
    }
}
