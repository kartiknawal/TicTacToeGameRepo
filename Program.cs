using System;

namespace TicTacToeGameNew
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic Tac Toe Game!");
            TicTacToeGame TicTacToe = new TicTacToeGame();
            char userLetter = TicTacToe.ChooseLetter();
        }
    }
}
