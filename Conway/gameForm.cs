using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conway
{
    public partial class gameForm : Form
    {
        Backend b;

        public gameForm()
        {
            InitializeComponent();
            b = new Backend();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            b.updateBoard();
            int[,] board = b.getBoard();
            String boardString = "";

            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i, j] == 0)
                        boardString += "-";
                    else
                        boardString += "+";
                }
                boardString += "\n";
            }
            label1.Text = boardString;
        }
    }
}
