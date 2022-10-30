using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame
{
    internal class TicTacToe
    {

        public static int[,] Matrix =
       {
            {1,2,3},
            {4,5,6},
            {7,8,9}
        };
        static int field1 = Matrix[0, 0];

        public bool Checker(string[,] board)
        {
            for (int i = 0; i < 3; i++)
            {
                if (board[i,0] == board[i, 1] && board[i, 1] == board[i, 2])
                    return true;
                if (board[0, i] == board[1, i] && board[1, i] == board[2, i])
                    return true;
            }
            if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
                return true;
            if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
                return true;

            return false;
        }

        public void PlayGame()
        {
            Console.WriteLine("Player 1 : Choose your field");
            var inputPlayer1 =int.TryParse(Console.ReadLine(), out int numP1);
            string cahrO;
            if (numP1 >= 0 && numP1 <= 9)
            {
                //cahrO = numP1;
            }
            else
            {
                Console.WriteLine("Incorect input! Please use another field!");
            }
            Console.WriteLine("Player 2 : Choose your field");
            var inputPlayer2 = int.TryParse(Console.ReadLine(), out int numP2);
            if (numP2 >= 0 && numP2 <= 9)
            {

            }
            else
            {
                Console.WriteLine("Incorect input! Please use another field!");
            }
        }
    }
}
