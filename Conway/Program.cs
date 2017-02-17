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
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
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
            Console.ReadLine(); // when user hits Enter, program terminates
        }

        static void printBoard(Object source, System.Timers.ElapsedEventArgs e)
        {
            //Console.Clear();
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
            int[,] tempBoard = new int[20, 20]
            {
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            };
            for (int i = 0; i < board.GetLength(0); i++) // y axis
            {
                for (int j = 0; j < board.GetLength(1); j++) // x axis
                {
                    int neighbors = checkLive(i, j); // is this supposed to be checkLive(i, j)???
                    //Console.Write("i: " + i + ", j: " + j + " neighbors: " + neighbors + " " + board[i, j]);
                    if (board[i, j] == 1) // removing this check produces odd behavior...
                    {
                        if (neighbors == 2 || neighbors == 3)
                        {
                            tempBoard[i, j] = 1;
                            Console.WriteLine("lives at " + i + ", " + j); // only getting one of these when we run...
                        }
                        if (neighbors < 2 || neighbors > 3)
                        {
                            tempBoard[i, j] = 0;
                            Console.WriteLine("dies at " + i + ", " + j + " neighbors: " + neighbors);
                        }
                    }
                    if (board[i, j] == 0 && neighbors == 3) // come to life!
                    {
                        tempBoard[i, j] = 1;
                    }
                }
            }
            board = tempBoard;
        }

        static int checkLive(int y, int x) // returns number of neighbors, but they aren't getting counted right.
        {
            int count = 0;
            #region Bounds Checking
            if (y == 0 && x == 0) // top left corner
            {
                for (int i = 0; i < 1; i++)
                {
                    for (int j = 0; j < 1; j++)
                    {
                        if (board[i, j] == 1)
                        {
                            count++;
                        }
                    }
                }
            }
            else if (y == 0 && x == board.GetLength(1) - 1) // top right corner
            {
                if (board[y + 1, x] == 1)
                {
                    count++;
                }
                if (board[y + 1, x - 1] == 1)
                {
                    count++;
                }
                if (board[y, x - 1] == 1)
                {
                    count++;
                }
            }
            else if (y == board.GetLength(0) - 1 && x == 0) // bottom left corner
            {
                if (board[y, x + 1] == 1)
                {
                    count++;
                }
                if (board[y - 1, x] == 1)
                {
                    count++;
                }
                if (board[y - 1, x + 1] == 1)
                {
                    count++;
                }
            }
            else if (y == board.GetLength(0) - 1 && x == board.GetLength(1) - 1) // bottom right corner
            {
                if (board[y - 1, x - 1] == 1)
                {
                    count++;
                }
                if (board[y, x - 1] == 1)
                {
                    count++;
                }
                if (board[y - 1, x] == 1)
                {
                    count++;
                }
            }
            else if (x == 0) // check left bound
            {
                if (board[y - 1, x] == 1)
                {
                    count++;
                }
                if (board[y - 1, x + 1] == 1)
                {
                    count++;
                }
                if (board[y, x + 1] == 1)
                {
                    count++;
                }
                if (board[y + 1, x + 1] == 1)
                {
                    count++;
                }
                if (board[y + 1, x] == 1)
                {
                    count++;
                }
            }
            else if (x == board.GetLength(1) - 1) // check right bounds
            { // TODO: Make sure this is good!
                if (board[y - 1, x] == 1)
                {
                    count++;
                }
                if (board[y - 1, x - 1] == 1)
                {
                    count++;
                }
                if (board[y + 1, x] == 1)
                {
                    count++;
                }
                if (board[y - 1, x - 1] == 1)
                {
                    count++;
                }
                if (board[y, x - 1] == 1)
                {
                    count++;
                }
            }
            else if (y == 0) // check top bounds
            {
                if (board[y, x + 1] == 1)
                {
                    count++;
                }
                if (board[y, x - 1] == 1)
                {
                    count++;
                }
                if (board[y + 1, x + 1] == 1)
                {
                    count++;
                }
                if (board[y + 1, x - 1] == 1)
                {
                    count++;
                }
                if (board[y + 1, x] == 1)
                {
                    count++;
                }
            }
            else if (y == board.GetLength(0) - 1) // check bottom bounds
            {
                if (board[y - 1, x] == 1)
                {
                    count++;
                }
                if (board[y - 1, x + 1] == 1)
                {
                    count++;
                }
                if (board[y, x + 1] == 1)
                {
                    count++;
                }
                if (board[y - 1, x - 1] == 1)
                {
                    count++;
                }
                if (board[y, x - 1] == 1)
                {
                    count++;
                }
            }
            #endregion
            else
            {
                if (board[y, x] == 1)
                {
                    Console.WriteLine("north: " + (y - 1) + " " + x + " | " + y + " " + x);
                }
                if (board[y - 1, x - 1] == 1)
                {
                    count++;
                }
                if (board[y - 1, x] == 1)
                {
                    count++;
                }
                if (board[y - 1, x + 1] == 1)
                {
                    count++;
                }
                if (board[y, x + 1] == 1)
                {
                    count++;
                }
                if (board[y + 1, x + 1] == 1)
                {
                    count++;
                }
                if (board[y + 1, x] == 1)
                {
                    count++;
                }
                if (board[y - 1, x - 1] == 1)
                {
                    count++;
                }
                if (board[y - 1, x] == 1)
                {
                    count++;
                }
            }
            return count;
        }
    }
}