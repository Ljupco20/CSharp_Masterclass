using System;

namespace Challenge_IfStatements2_2
{
    internal class Program
    {
        static int highScore = 300;
        static string highscorePlayer = "Ljupco";
        static void Main(string[] args)
        {
            CheckHighScore(250, "Marijana");
            CheckHighScore(330, "Petar");
            CheckHighScore(350, "Fico");
            Console.Read();
        }
        public static void CheckHighScore(int score, string playerName)
        {
        

            if (score > highScore)
            {
                highScore = score;
                highscorePlayer = playerName;   
                Console.WriteLine($"New highscore is {highScore}, and its held by {highscorePlayer}");
            }
            else
            {
                Console.WriteLine($"Your score is {score} {playerName}, and the highscore still reamins {highScore} ");
            }
        }
    }
}
