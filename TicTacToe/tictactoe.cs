using System;
namespace PracTest4
{
    class tictactoe
    {
        static void Main()
        {

            int row = 0;
            int col = 0;
            char[,] tictactoe;
            tictactoe = new char[3, 3];

            for (row = 0; row < tictactoe.GetLength(0); row++)
                for (col = 0; col < tictactoe.GetLength(1); col++)
                    tictactoe[row, col] = '_';

            Console.WriteLine("begin the game:");
            for (row = 0; row < tictactoe.GetLength(0); row++)
            {
                for (col = 0; col < tictactoe.GetLength(1); col++)
                {
                    Console.Write(tictactoe[row, col] + " ");
                }
                Console.WriteLine();
            }

            tictactoe[0, 0] = 'X';
            tictactoe[2, 2] = 'O';
            tictactoe[1, 0] = 'X';
            tictactoe[2, 0] = 'X';

            Console.WriteLine("after a few turns:");
            for (row = 0; row < tictactoe.GetLength(0); row++)
            {
                for (col = 0; col < tictactoe.GetLength(1); col++)
                {
                    Console.Write(tictactoe[row, col] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
