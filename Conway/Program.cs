using System;
using System.Windows.Forms;

namespace Conway
{
    class Program
    {
        static void Main(string[] args)
        {
            Backend b = new Backend();

            System.Timers.Timer step = new System.Timers.Timer();
            step.Interval = 150;
            step.Elapsed += b.printBoard;
            step.Enabled = true;

            Console.WindowHeight = 30; // TODO: confirm this won't break on a different computer
            Console.CursorVisible = false; // prevents cursor from flashing all over the place and being an eye-sore
            Console.ReadLine(); // when user hits Enter, program terminates

            Application.EnableVisualStyles();
            Application.Run(new gameForm());
        }
    }
}