using System;
using System.Collections;
using System.Timers;

namespace Conway
{
    class Program
    {
        static int[,] board;
        static int generations;
        static Boolean stabilizationOccurred;

        static void Main(string[] args)
        {
            #region empty board
            /*
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
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }
            };
            */
            #endregion
            #region cool seed!
            /*
            board = new int[20, 20]
            {
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
                { 0, 0, 1, 1, 1, 0, 0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 1, 0, 1, 0, 1 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 1, 0, 1, 0, 1, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 1, 0, 1 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 1, 0, 1, 0 }
            };
            */
            #endregion
            #region brighan board
            /*      
            board = new int[20, 20]
            {
                { 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0 },
                { 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1 },
                { 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0 },
                { 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1 },
                { 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0 },
                { 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1 },
                { 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0 },
                { 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1 },
                { 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0 },
                { 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1 },
                { 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0 },
                { 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1 },
                { 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0 },
                { 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1 },
                { 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0 },
                { 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1 },
                { 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0 },
                { 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1 },
                { 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0 },
                { 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1 }
            }; */
            #endregion
            #region brighan board 2.0
            /*
            board = new int[20, 20]
            {
                { 0, 0, 1, 1, 0, 0, 1, 1, 0, 0, 1, 1, 0, 0, 1, 1, 0, 0, 1, 1 },
                { 1, 1, 0, 0, 1, 1, 0, 0, 1, 1, 0, 0, 1, 1, 0, 0, 1, 1, 0, 0 },
                { 0, 0, 1, 1, 0, 0, 1, 1, 0, 0, 1, 1, 0, 0, 1, 1, 0, 0, 1, 1 },
                { 1, 1, 0, 0, 1, 1, 0, 0, 1, 1, 0, 0, 1, 1, 0, 0, 1, 1, 0, 0 },
                { 0, 0, 1, 1, 0, 0, 1, 1, 0, 0, 1, 1, 0, 0, 1, 1, 0, 0, 1, 1 },
                { 1, 1, 0, 0, 1, 1, 0, 0, 1, 1, 0, 0, 1, 1, 0, 0, 1, 1, 0, 0 },
                { 0, 0, 1, 1, 0, 0, 1, 1, 0, 0, 1, 1, 0, 0, 1, 1, 0, 0, 1, 1 },
                { 1, 1, 0, 0, 1, 1, 0, 0, 1, 1, 0, 0, 1, 1, 0, 0, 1, 1, 0, 0 },
                { 0, 0, 1, 1, 0, 0, 1, 1, 0, 0, 1, 1, 0, 0, 1, 1, 0, 0, 1, 1 },
                { 1, 1, 0, 0, 1, 1, 0, 0, 1, 1, 0, 0, 1, 1, 0, 0, 1, 1, 0, 0 },
                { 0, 0, 1, 1, 0, 0, 1, 1, 0, 0, 1, 1, 0, 0, 1, 1, 0, 0, 1, 1 },
                { 1, 1, 0, 0, 1, 1, 0, 0, 1, 1, 0, 0, 1, 1, 0, 0, 1, 1, 0, 0 },
                { 0, 0, 1, 1, 0, 0, 1, 1, 0, 0, 1, 1, 0, 0, 1, 1, 0, 0, 1, 1 },
                { 1, 1, 0, 0, 1, 1, 0, 0, 1, 1, 0, 0, 1, 1, 0, 0, 1, 1, 0, 0 },
                { 0, 0, 1, 1, 0, 0, 1, 1, 0, 0, 1, 1, 0, 0, 1, 1, 0, 0, 1, 1 },
                { 1, 1, 0, 0, 1, 1, 0, 0, 1, 1, 0, 0, 1, 1, 0, 0, 1, 1, 0, 0 },
                { 0, 0, 1, 1, 0, 0, 1, 1, 0, 0, 1, 1, 0, 0, 1, 1, 0, 0, 1, 1 },
                { 1, 1, 0, 0, 1, 1, 0, 0, 1, 1, 0, 0, 1, 1, 0, 0, 1, 1, 0, 0 },
                { 0, 0, 1, 1, 0, 0, 1, 1, 0, 0, 1, 1, 0, 0, 1, 1, 0, 0, 1, 1 },
                { 1, 1, 0, 0, 1, 1, 0, 0, 1, 1, 0, 0, 1, 1, 0, 0, 1, 1, 0, 0 }
            };
            */
            #endregion
            #region north-bound ship
            /*
            board = new int[20, 20]
            {
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 1, 1, 0, 0, 0, 1, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0 },
                { 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0 },
                { 0, 0, 0, 0, 1, 0, 1, 1, 0, 1, 0, 1, 0, 1, 1, 0, 1, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }
            };
            */
            #endregion
            #region south-bound ship
            /*
            board = new int[20, 20]
            {
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 1, 0, 1, 1, 0, 1, 0, 1, 0, 1, 1, 0, 1, 0, 0, 0 },
                { 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0 },
                { 0, 0, 0, 0, 1, 1, 0, 0, 0, 1, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }
            };
            */
            #endregion
            #region east-bound glider
            /*
            board = new int[20, 20]
            {
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0 },
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
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }
            };
            */
            #endregion
            board = new int[20, 38]
            {
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0 },
                { 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0 },
                { 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 1, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0 },
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
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }
            };
            #region ban board
            /*
            board = new int[20, 20]
            {
                { 0, 1, 0, 0, 1, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 1, 1, 1, 1 },
                { 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 1, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0 },
                { 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1 }
            };
            */
            #endregion
            generations = 1;
            stabilizationOccurred = true;

            Timer step = new Timer();
            step.Interval = 150;
            step.Elapsed += printBoard;
            step.Enabled = true;
            /*printBoard();
            printBoard();
            printBoard();
            printBoard();
            printBoard();
            printBoard();
            printBoard();
            printBoard();
            printBoard();
            printBoard();
            printBoard();
            printBoard();
            printBoard();*/

            Console.CursorVisible = false; // this is for even prettier stuff! prevents cursor from flashing all over the place and being an eye-sore
            Console.ReadLine(); // when user hits Enter, program terminates
        }

        static void printBoard(Object source, System.Timers.ElapsedEventArgs e)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    Console.SetCursorPosition(j, i); // this makes printing smooth!
                    if (board[i, j] == 0)
                        Console.Write("-");
                    else
                        Console.Write("+");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Generations: " + generations + "\nPress Enter to exit");
            updateBoard();
            generations++;
        }

        static void updateBoard()
        {
            #region tempBoard definition
            int[,] tempBoard = new int[20, 38]
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
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }
            };
            #endregion
            for (int i = 0; i < board.GetLength(0); i++) // y axis
            {
                for (int j = 0; j < board.GetLength(1); j++) // x axis
                {
                    int neighbors = checkLive(i, j);
                    if (board[i, j] == 1) // removing this check produces odd behavior...
                    {
                        if (neighbors == 2 || neighbors == 3)
                        {
                            tempBoard[i, j] = 1;
                        }
                        else
                        {
                            //Console.WriteLine("Dead at: " + i + ", " + j + ". Neighbors: " + neighbors);
                            tempBoard[i, j] = 0;
                        }
                    }
                    if (board[i, j] == 0 && neighbors == 3) // come to life!
                    {
                        //Console.WriteLine("Alive at: " + i + ", " + j);
                        tempBoard[i, j] = 1;
                    }
                }
                //Console.WriteLine("NEXT!");
            }
            // checks for stabilization
            Boolean stable = true;
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (!(board[i, j] == tempBoard[i, j]))
                    {
                        stable = false;
                        stabilizationOccurred = false;
                        break;
                    }
                }
            }
            if (stable && stabilizationOccurred)
            {
                //Console.WriteLine("Stabilized at generation " + generations + "!");
                stabilizationOccurred = false; // prevents another printing of our stable-generation-number thing
            }
            board = tempBoard;
        }

        static int checkLive(int y, int x) // returns number of neighbors. TODO: This is in need of major clean up, these statements can more than likely be condensed a line or 100.
        {
            ArrayList spotChecked = new ArrayList();
            // TODO: Add test case/bound checking for diagonal gliders, also a test case for corners of board.
            // Do we need to be checking for the "opposite" side of the board? Example: for board.GetLength(0) == 20: at position 0, 1: checkLive checks for cells at 0, 19.
            int count = 0;
            if (y - 1 >= 0  && board[y - 1, x] == 1) // check top bound
            {
                count++;
                //Console.WriteLine("QQSo this happened.." + y + ", " + x + "Count: " + count + " Spot: " + (y - 1) + ", " + x);
                spotChecked.Add("" + (y - 1) + (x));
            }
            if (y + 1 < board.GetLength(1) && board[y + 1, x] == 1 && (y != board.GetLength(1) - 1/* && x != 0*/)) // check bottom bound
            {
                count++;
                //Console.WriteLine("!!!!So this happen.." + y + ", " + x + "Count: " + count + "Spot: " + (y + 1) + ", " + x);
                spotChecked.Add("" + (y + 1) + (x));
            }
            if (x - 1 >= 0 && board[y, x - 1] == 1) // check left bound
            {
                count++;
                //Console.WriteLine("???So this happ.." + y + ", " + x + "Count: " + count + " Spot: " + (y) + ", " + (x - 1));
                spotChecked.Add("" + (y) + (x - 1));
            }
            if (x + 1 < board.GetLength(1) && board[y, x + 1] == 1) // check right bound
            {
                count++;
                //Console.WriteLine(",,,,,,,,,So this ha.." + y + ", " + x + "Count: " + count + " Spot: " + y + ", " + (x + 1));
                spotChecked.Add("" + (y - 1) + (x));
            }
            if (x - 1 >= 0 && y - 1 >= 0 && board[y - 1, x - 1] == 1) // check top left bound
            {
                count++;
                //Console.WriteLine(";;;;So this happened.." + y + ", " + x + "Count: " + count);
                spotChecked.Add("" + (y - 1) + (x - 1));
            }
            if (x + 1 < board.GetLength(1) && y - 1 >= 0 && board[y - 1, x + 1] == 1) // check top right bound
            {
                count++;
                //Console.WriteLine("LLSo this happened.." + y + ", " + x + "Count: " + count + " Spot: " + (y - 1) + ", " + (x + 1));
                spotChecked.Add("" + (y - 1) + (x + 1));
            }
            if (x - 1 >= 0 && y + 1 < board.GetLength(0) && board[y + 1, x - 1] == 1) // check bottom left bound
            {
                count++;
                //Console.WriteLine("PPSo this happened.." + y + ", " + x + "Count: " + count);
                spotChecked.Add("" + (y + 1) + (x - 1));
            }
            if (x + 1 < board.GetLength(1) && y + 1 < board.GetLength(0) && board[y + 1, x + 1] == 1) // check bottom right bound
            {
                count++;
                //Console.WriteLine("NNSo this happened.." + y + ", " + x + "Count: " + count + (y + 1) + ", " + (x + 1));
                spotChecked.Add("" + (y + 1) + (x + 1));
            }

            #region Wrap Around Stuffs for north/south bound cells
            // not checking for diagonal neighbors on opposite ends of board?
            if (y == 0 && x < board.GetLength(1) && x > 0 && (board[board.GetLength(0) - 1, x] == 1)) // check the bottom of the board, so we can wrap around and set the top to be alive if needed
            {
                count++;
                //Console.WriteLine("VVSo this happened.." + y + ", " + x + "Count: " + count + " Spot: " + (board.GetLength(0) - 1) + ", " + x);
                spotChecked.Add("" + (board.GetLength(0) - 1) + (x));
            }
            if (y == 0 && x < board.GetLength(1) && x > 0 && (board[board.GetLength(0) - 1, x - 1] == 1)) // check the bottom of the board, so we can wrap around and set the top to be alive if needed
            {
                count++;
                //Console.WriteLine("ZSo this happened.." + y + ", " + x + "Count: " + count + " Spot: " + (board.GetLength(0) - 1) + ", " + (x - 1));
                spotChecked.Add("" + (board.GetLength(0) - 1) + (x - 1));
            }
            if (y == 0 && x < board.GetLength(1) - 1 && x > 0 && (board[board.GetLength(0) - 1, x + 1] == 1)) // check the bottom of the board, so we can wrap around and set the top to be alive if needed
            {
                count++;
                //Console.WriteLine("XSo this happened.." + y + ", " + x + "Count: " + count);
                spotChecked.Add("" + (board.GetLength(0) - 1) + (x + 1));
            }
            //////////// other side of board
            if (y == board.GetLength(0) - 1 && x < board.GetLength(1) - 1 && x > 0 && (board[0, x] == 1)) // check the top of the board, so we can wrap around and set the top to be alive if needed
            {
                count++;
                //Console.WriteLine("SSo this happened.." + y + ", " + x + "Count: " + count);
            }
            if (y == board.GetLength(0) - 1 && x < board.GetLength(1) - 1 && x > 0 && (board[0, x - 1] == 1)) // check the top of the board, so we can wrap around and set the top to be alive if needed
            {
                count++;
                //Console.WriteLine("FSo this happened.." + y + ", " + x + "Count: " + count);
            }
            if (y == board.GetLength(0) - 1 && x < board.GetLength(1) - 1 && x > 0 && (board[0, x + 1] == 1)) // check the top of the board, so we can wrap around and set the top to be alive if needed
            {
                count++;
                //Console.WriteLine("ESo this happened.." + y + ", " + x + "Count: " + count);
            }
            #endregion
            #region Wrap Around Stuffs for east/west bound cells
            // east-bound
            // TODO: Not testing corners at all, if we fix that then we should have propor periodic boundary conditions.
            if (x == 0 && y < board.GetLength(0) - 1 && y > 0 && (board[y, board.GetLength(1) - 1] == 1))
            {
                count++;
                //Console.WriteLine("DSo this happened.." + y + ", " + x + "Count: " + count);
            }
            if (x == 0 && y < board.GetLength(0) - 1 && y > 0 && (board[y - 1, board.GetLength(1) - 1] == 1))
            {
                count++;
                //Console.WriteLine("CCSo this happened.." + y + ", " + x + "Count: " + count + " Spot: " + (y - 1) + ", " + (board.GetLength(1) - 1));
            }
            if (x == 0 && y < board.GetLength(0) - 1 && y > 0 && (board[y + 1, board.GetLength(1) - 1] == 1))
            {
                count++;
                //Console.WriteLine("BBBB this happened.." + y + ", " + x + "Count: " + count);
            }
            // west-bound
            if (x == board.GetLength(1) - 1 && y < board.GetLength(0) - 1 && y > 0 && (board[y, 0] == 1))
            {
                count++;
                //Console.WriteLine("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAASoAASo this happened.." + y + ", " + x + "Count: " + count);
            }
            if (x == board.GetLength(1) - 1 && y < board.GetLength(0) - 1 && y > 0 && (board[y - 1, 0] == 1))
            {
                count++;
                //Console.WriteLine("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAASoASo this happened.." + y + ", " + x + "Count: " + count);
            }
            if (x == board.GetLength(1) - 1 && y < board.GetLength(0) - 1 && y > 0 && (board[y + 1, 0] == 1))
            {
                count++;
                //Console.WriteLine("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAASo this happened.." + y + ", " + x + "Count: " + count);
            }
            #endregion
            // for top left corner
            if (x == 0 && y == 0 && (board[0, board.GetLength(1) - 1] == 1))
            {
                count++;
                //Console.WriteLine(" this hfffappened.." + y + ", " + x + "Count: " + count + " Spot: " + 0, ", " + (board.GetLength(1) - 1));
            }
            if (x == 0 && y == 0 && (board[board.GetLength(0) - 1, 0] == 1))
            {
                count++;
                //Console.WriteLine(" this hacccppened.." + y + ", " + x + "Count: " + count + " Spot: " + (board.GetLength(0) - 1) + ", " + 0);
            }
            if (x == 0 && y == 0 && (board[board.GetLength(0) - 1, board.GetLength(1) - 1] == 1))
            {
                count++;
                //Console.WriteLine(" this haaaappened.." + y + ", " + x + "Count: " + count + " Spot: " + (board.GetLength(0) - 1) + ", " + (board.GetLength(1) - 1));
            }
            /*if (x == 0 && y == 0 && (board[y, x + 1] == 1) && !(spotChecked.Contains("" + y + (x + 1))))
            {
                count++;
                Console.WriteLine(" this happeeeened.." + y + ", " + x + "Count: " + count + " Spot: " + y + ", " + (x + 1));
            }*/
            if (x == 0 && y == 0 && (board[y + 1, x] == 1) && !(spotChecked.Contains("" + (y + 1) + x)))
            {
                count++;
                //Console.WriteLine("this happenedggg.." + y + ", " + x + "Count: " + count + " Spot: " + (y + 1) + ", " + x);
            }
            /*if (x == 0 && y == 0 && (board[y + 1, x + 1] == 1))
            {
                count++;
                Console.WriteLine(" this happened..hhh" + y + ", " + x + "Count: " + count + " Spot: " + (y + 1) + ", " + (x + 1));
            }*/
            if (x == 0 && y == 0 && (board[board.GetLength(0) - 1, 1] == 1))
            {
                count++;
                //Console.WriteLine(" this hajjjjppened.." + y + ", " + x + "Count: " + count + " Spot: " + (board.GetLength(0) - 1) + ", " + (1));
            }
            if (x == 0 && y == 0 && (board[1, board.GetLength(1) - 1] == 1))
            {
                count++;
                //Console.WriteLine(" this happenpppppppped.." + y + ", " + x + "Count: " + count + " Spot: " + (1) + ", " + (board.GetLength(1) - 1));
            }
            // for top right corner
            if (x == board.GetLength(1) - 1 && y == 0 && (board[0, 0] == 1))
            {
                count++;
                //Console.WriteLine("we done happened this happened.." + y + ", " + x + "Count: " + count + " Spot: " + 0 + ", " + 0);
            }
            if (x == board.GetLength(1) - 1 && y == 0 && (board[board.GetLength(0) - 1, 0] == 1)) // problem here?
            {
                count++;
                //Console.WriteLine("kill mes this happened.." + y + ", " + x + "Count: " + count + " Spot: " + (board.GetLength(0) - 1) + ", " + 0);
            }
            if (x == board.GetLength(1) - 1 && y == 0 && (board[board.GetLength(0) - 1, board.GetLength(1) - 1] == 1) && !(spotChecked.Contains("" + (board.GetLength(0) - 1) + (board.GetLength(1) - 1))))
            {
                count++;
                //Console.WriteLine("no u this happened.." + y + ", " + x + "Count: " + count + " Spot: " + (board.GetLength(0) - 1) + ", " + (board.GetLength(1) - 1));
                spotChecked.Add("" + (board.GetLength(0) - 1) + (board.GetLength(1) - 1));

            }
            if (x == board.GetLength(1) - 1 && y == 0 && (board[y, x - 1] == 1) && !(spotChecked.Contains("" + (y) + (x - 1))))
            {
                count++;
                //Console.WriteLine(": (  this happened.." + y + ", " + x + "Count: " + count + " Spot: " + y + ", " + (x - 1));
            }
            if (x == board.GetLength(1) - 1 && y == 0 && (board[y + 1, x] == 1) && !(spotChecked.Contains("" + (y + 1) + x)))
            {
                count++;
                //Console.WriteLine(":&&&&&&&&&&&&& this happened.." + y + ", " + x + "Count: " + count + " Spot: " + (y + 1) + ", " + x);
            }
            if (x == board.GetLength(1) - 1 && y == 0 && (board[y + 1, x - 1] == 1))
            {
                count++;
                //Console.WriteLine("CRAZY this happened.." + y + ", " + x + "Count: " + count + " Spot: " + (y + 1) + ", " + (x - 1));
            }
            if (x == board.GetLength(1) - 1 && y == 0 && (board[board.GetLength(0) - 1, board.GetLength(1) - 2] == 1) && !(spotChecked.Contains("" + (board.GetLength(0) - 1) + (board.GetLength(1) - 2))))
            {
                count++;
                //Console.WriteLine("hahhaa owwo this occur?.." + y + ", " + x + "Count: " + count + " Spot: " + (board.GetLength(0) - 1) + ", " + (board.GetLength(1) - 2));
            }
            if (x == board.GetLength(1) - 1 && y == 0 && (board[1, 0] == 1))
            {
                count++;
                //Console.WriteLine("{}{}{}{}{}{ this happened.." + y + ", " + x + "Count: " + count + " Spot: " + (0) + ", " + 1);
            }
            // bottom right corner
            if (x == board.GetLength(1) - 1 && y == board.GetLength(0) - 1 && (board[0, board.GetLength(1) - 1] == 1))
            {
                count++;
                //Console.WriteLine("AAAAAAAAAAAAAAAASo this happened.." + y + ", " + x + "Count: " + count);
            }
            if (x == board.GetLength(1) - 1 && y == board.GetLength(0) - 1 && (board[0, 0] == 1))
            {
                count++;
                //Console.WriteLine("AAAAAAAAAAAAAAASo this happened.." + y + ", " + x + "Count: " + count);
            }
            if (x == board.GetLength(1) - 1 && y == board.GetLength(0) - 1 && (board[board.GetLength(0) - 1, 0] == 1))
            {
                count++;
                //Console.WriteLine("AAAAAAAAAAAAAASo this happened.." + y + ", " + x + "Count: " + count);
            }
            /*if (x == board.GetLength(1) - 1 && y == board.GetLength(0) - 1 && (board[y, x - 1] == 1))
            {
                count++;
                Console.WriteLine("13 this happened.." + y + ", " + x + "Count: " + count + "spot: " + y + ", " + (x - 1));
            }/*
            if (x == board.GetLength(1) - 1 && y == board.GetLength(0) - 1 && (board[y - 1, x] == 1)) // !!! we are already checking this above..
            {
                count++;
            }*/
            if (x == board.GetLength(1) - 1 && y == board.GetLength(0) - 1 && (board[y - 1, x - 1] == 1))
            {
                count++;
                //Console.WriteLine("AAAAAAAAAAAASo this happened.." + y + ", " + x + "Count: " + count);
            }
            if (x == board.GetLength(1) - 1 && y == board.GetLength(0) - 1 && (board[0, board.GetLength(1) - 2] == 1))
            {
                count++;
                //Console.WriteLine("11 this happened.." + y + ", " + x + "Count: " + count + "spot: " + 0 + ", " + (board.GetLength(1) - 2));
            } 
            if (x == board.GetLength(1) - 1 && y == board.GetLength(0) - 1 && (board[board.GetLength(0) - 2, 0] == 1))
            {
                count++;
                //Console.WriteLine("AAAAAAAAAASo this happened.." + y + ", " + x + "Count: " + count + " Spot: " + (board.GetLength(1) - 1) + ", " + 0);
            }
            // bottom left corner
            if (x == 0 && y == board.GetLength(0) - 1 && (board[0, 1] == 1))
            {
                count++;
                //Console.WriteLine("AAAAAAAAASo this happened.." + y + ", " + x + "Count: " + count + " Spot: " + (board.GetLength(1) - 1) + ", " + 0);
            }
            if (x == 0 && y == board.GetLength(0) - 1 && (board[0, 0] == 1))
            {
                count++;
                //Console.WriteLine("AAAAAAAASo this happened.." + y + ", " + x + "Count: " + count + " Spot: " + (0) + ", " + (0));
            }
            if (x == 0 && y == board.GetLength(0) - 1 && (board[0, board.GetLength(1) - 1] == 1))
            {
                count++;
                //Console.WriteLine("AASo this happened.." + y + ", " + x + "Count: " + count + " Spot: " + (0) + ", " + (board.GetLength(1) - 1));
            }
            if (x == 0 && y == board.GetLength(0) - 1 && (board[board.GetLength(0) - 1, board.GetLength(1) - 1] == 1))
            {
                count++;
                //Console.WriteLine("AAAAAAASo this happened.." + y + ", " + x + "Count: " + count);
            }
            if (x == 0 && y == board.GetLength(0) - 1 && (board[board.GetLength(0) - 2, board.GetLength(1) - 1] == 1)) // this might not be right.
            {
                count++;
                //Console.WriteLine("ASo this happened.." + y + ", " + x + "Count: " + count + " Spot: " + (board.GetLength(0) - 2) + ", " + (board.GetLength(1) - 1));
            }
            if (x == 0 && y == board.GetLength(0) - 1 && (board[y, x + 1] == 1))
            {
                count++;
                //Console.WriteLine("AAAAASo this happened.." + y + ", " + x + "Count: " + count);
            }
            if (x == 0 && y == board.GetLength(0) - 1 && (board[y - 1, x] == 1))
            {
                count++;
                //Console.WriteLine("AAAASo this happened.." + y + ", " + x + "Count: " + count);
            }
            if (x == 0 && y == board.GetLength(0) - 1 && (board[y - 1, x + 1] == 1))
            {
                count++;
                //Console.WriteLine("AAASo this happened.." + y + ", " + x + "Count: " + count);
            }
            return count;
        }
    }
}