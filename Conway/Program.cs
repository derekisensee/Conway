using System;
using System.Windows.Forms;

namespace Conway
{
    class Program
    {
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.Run(new gameForm());
        }
    }
}