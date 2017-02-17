using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Conway
{
    class Program
    {
        static int[,] board;

        static void Main(string[] args)
        {
            #region initial board
            board = new int[20, 20] 
            { 
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }
            };
            #endregion
            Timer step = new Timer();
            step.Interval = 1000;
            step.Elapsed += printBoard;
            step.Enabled = true;
            Console.ReadLine();
        }

        static void printBoard(Object source, System.Timers.ElapsedEventArgs e)
        {
            Console.Clear();
            Console.WriteLine("Press Enter to exit");
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    Console.Write(board[i, j]);
                }
                Console.WriteLine();
            }
            updateBoard();
        }

        static void updateBoard() // TODO: instead of directly updating the board, i need to make a new 2d array that takes the existing board as the sample to check neighbors from.
        {                         // pretty sure updating the board directly is my problem.
            for (int i = 0; i < board.GetLength(0); i++) // y axis
            {
                for (int j = 0; j < board.GetLength(1); j++) // x axis
                {
                    int neighbors = checkLive(i, j);
                    /*if (neighbors > 1)
                    {
                        Console.WriteLine("neighbors: " + neighbors + "coordinates: " + i + ", " + j);
                    }*/
                    if (board[i, j] == 1) // removing this check produces odd behavior...
                    {
                        if (neighbors < 2)
                        {
                            board[i, j] = 0;
                        }
                        if (neighbors > 3)
                        {
                            board[i, j] = 0;
                        }
                        if (neighbors == 2 || neighbors == 3)
                        {
                            board[i, j] = 1;
                        }
                    }
                    /*if (neighbors < 2)
                    {
                        board[i, j] = 0;
                    }
                    if (neighbors > 3)
                    {
                        board[i, j] = 0;
                    }
                    if (neighbors == 2 || neighbors == 3)
                    {
                        board[i, j] = 1;
                    } */
                    if (board[i, j] == 0 && neighbors == 3)
                    {
                        board[i, j] = 1;
                    }
                }
            }
        }

        static int checkLive(int y, int x) // returns neighbors
        {
            int count = 0;
            if (y - 1 >= 0 && board[y - 1, x] == 1) // check top bound
            {
                count++;
            }
            if (y + 1 > board.GetLength(1) && board[y + 1, x] == 1) // check bottom bound
            {
                count++;
            }
            if (x - 1 > 0 && board[y, x] == 1) // check left bound
            {
                count++;
            }
            if (x + 1 < /*do we need >=?*/ board.GetLength(1) && board[y, x + 1] == 1) // check right bound
            {
                count++;
            }
            if (x - 1 > 0 && y - 1 > 0 && board[y - 1, x - 1] == 1) // check top left bound
            {
                count++;
            }
            if (x + 1 < board.GetLength(1) && y - 1 > 0 && board[y - 1, x + 1] == 1) // check top right bound
            {
                count++;
            }
            if (x - 1 > 0 && y + 1 > board.GetLength(0) && board[y + 1, x - 1] == 1) // check bottom left bound
            {
                count++;
            }
            if (x + 1 < board.GetLength(1) && y + 1 < board.GetLength(0) && board[y + 1, x + 1] == 1) // check bottom right bound
            {
                count++;
            }
            return count;
        }
    }
}