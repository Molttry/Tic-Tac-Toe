using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int turns = 9;
            char player = 'X';
            char[,] board = new char[3, 3];
            BoardEx(board);

            while (true)
            {
                Console.Clear();
                Print(board);
                Console.WriteLine("Player '" + player + "' is playing!");
                Console.WriteLine("Select the row");
                int row = Convert.ToInt32(Console.ReadLine()) - 1;
                Console.WriteLine("Select column");
                int col = Convert.ToInt32(Console.ReadLine()) - 1;
                board[row, col] = player;
                turns--;
                if (turns == 0)
                {
                    Console.Clear();
                    Print(board);
                    Console.WriteLine("We have a draw here 'X' and 'O' pretty good at this game");
                    break;
                }
                if (player == board[0, 0] && player == board[0, 1] && player == board[0, 2])
                {
                    Console.Clear();
                    Print(board);
                    Console.WriteLine("Very cool! Player '" + player + "' won!");
                    break;
                }
                else if (player == board[1, 0] && player == board[1, 1] && player == board[1, 2])
                {
                    Console.Clear();
                    Print(board);
                    Console.WriteLine("Very cool! Player '" + player + "' won!");
                    break;
                }
                else if (player == board[2, 0] && player == board[2, 1] && player == board[2, 2])
                {
                    Console.Clear();
                    Print(board);
                    Console.WriteLine("Very cool! Player '" + player + "' won!");
                    break;
                }
                else if (player == board[0, 0] && player == board[1, 0] && player == board[2, 0])
                {
                    Console.Clear();
                    Print(board);
                    Console.WriteLine("Very cool! Player '" + player + "' won!");
                    break;
                }
                else if (player == board[0, 1] && player == board[1, 1] && player == board[2, 1])
                {
                    Console.Clear();
                    Print(board);
                    Console.WriteLine("Very cool! Player '" + player + "' won!");
                    break;
                }
                else if (player == board[0, 2] && player == board[1, 2] && player == board[2, 2])
                {
                    Console.Clear();
                    Print(board);
                    Console.WriteLine("Very cool! Player '" + player + "' won!");
                    break;
                }
                else if (player == board[0, 0] && player == board[1, 1] && player == board[2, 2])
                {
                    Console.Clear();
                    Print(board);
                    Console.WriteLine("Very cool! Player '" + player + "' won!");
                    break;
                }
                else if (player == board[0, 2] && player == board[1, 1] && player == board[2, 0])
                {
                    Console.Clear();
                    Print(board);
                    Console.WriteLine("Very cool! Player '" + player + "' won!");
                    break;
                }
                if (player == 'X')
                {
                    player = 'O';
                }
                else
                {
                    player = 'X';
                }

            }
            Console.WriteLine("To exit the game just press any button");
            Console.ReadKey();

        }
        static void BoardEx(char[,] board)
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                    board[row, col] = ' ';
            }
        }
        static void Print(char[,] board)
        {
            for (int row = 0; row < 3; row++)
            {

                Console.Write(row + 1 + "| ");
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(board[row, col]);
                    Console.Write(" | ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("   1   2   3   ");
        }




    }
}
