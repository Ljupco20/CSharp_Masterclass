using System;

namespace ChallengeLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "0";
            int count = 0;
            int total = 0;
            int currentNumber = 0;

            while(input != "-1")
            {
                Console.WriteLine($"Last number was {currentNumber}");
                Console.WriteLine("Please enter the next score");
                Console.WriteLine($"Current amount of entries {count}");
                Console.WriteLine("Please enter -1 once you are ready to calculate the average");
                input = Console.ReadLine();
                if (input.Equals("-1"))
                {
                    Console.WriteLine("-------------------------------------------------------");
                    //Calculate average and let the teacher know
                    double average = (double)total / (double)count;
                    Console.WriteLine($"The average score of your students is {average}");
                }
                if(int.TryParse(input, out currentNumber) && currentNumber >0 && currentNumber <=20)
                {
                    total+=currentNumber;
                    
                }
                else
                {
                    if(!(input.Equals("-1")))
                    {
                        Console.WriteLine("Please enter a value between 1 and 20");
                    }
                    continue;
                }
                count++;
            }


        }
    }
}
