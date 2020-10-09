using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeGameNew
{
    class TicTacToeGame
    {
        char[] board = new char[10];
        public void CreateBoard()
        {
            int i;
            for (i = 1; i < 10; i++)
            {
                board[i] = ' ';
            }
        }
        public char ChooseLetter()
        {
            Console.WriteLine("Choose between X or O : ");
            char letter = Convert.ToChar(Console.ReadLine());
            return letter;
        }

        public void ShowBoard()
        {
            Console.WriteLine("\n" + board[1] + " | " + board[2] + " | " + board[3]);
            Console.WriteLine("__________");
            Console.WriteLine("\n" + board[4] + " | " + board[5] + " | " + board[6]);
            Console.WriteLine("__________");
            Console.WriteLine("\n" + board[7] + " | " + board[8] + " | " + board[9]);
        }

    }
}