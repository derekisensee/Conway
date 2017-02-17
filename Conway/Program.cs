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
            step.Interval = 1500;
            step.Elapsed += printBoard;
            step.Enabled = true;
            Console.ReadLine();
        }

        static void printBoard(Object source, System.Timers.ElapsedEventArgs e)
        {
            updateBoard();
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
        }

        static void updateBoard()
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    int neighbors = checkLive(i, j);
                    if (board[i, j] == 1)
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
            else if (y == board.GetLength(1) - 1 && x == 0) // bottom left corner
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
            else if (y == board.GetLength(1) - 1 && x == board.GetLength(0) - 1) // bottom right corner
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
            else
            {
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
            #endregion
            return count;
        }
    }
}