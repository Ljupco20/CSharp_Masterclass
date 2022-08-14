using System;

namespace Challenge_IfStatements2
{
    internal class Program
    {
        
       
        
        static void Main(string[] args)
        {
            CheckScore();
            Console.ReadKey();
        }

        public static void CheckScore()
        {
            Console.WriteLine("Please enter your player name:");
            string highscorePlayer = Console.ReadLine();
            Random rnd = new Random();
            int score = rnd.Next(200);
            int highscore = 100;

            if (score > highscore)
            {
               highscore = score;
                Console.WriteLine($"New highscore is {highscore}, and its held by {highscorePlayer}");
            }
            else
            {
                Console.WriteLine($"Your score is {score}, and the highscore still reamins {highscore} ");
            }
        }
    }
}
