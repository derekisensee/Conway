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
        Boolean paused;

        public gameForm()
        {
            InitializeComponent();
            b = new Backend();
            paused = false;
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
                        boardString += ". ";
                    else
                    {
                        boardString += "+";
                    }
                }
                boardString += "\n";
            }
            label1.Text = boardString;
        }

        private void pause_Click(object sender, EventArgs e)
        {
            if (paused)
            {
                timer1.Start();
                paused = false;
            }
            else
            {
                timer1.Stop();
                paused = true;
            }
        }

        private void decTime_Click(object sender, EventArgs e)
        {
            timer1.Interval += 10;
            currInterval.Text = timer1.Interval + "ms";
        }

        private void incTime_Click(object sender, EventArgs e)
        {
            if (!(timer1.Interval == 10))
            {
                timer1.Interval -= 10;
                currInterval.Text = timer1.Interval + "ms";
            }
        }

        private void zoomIn_Click(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font.FontFamily, label1.Font.Size + 2);
        }

        private void zoomOut_Click(object sender, EventArgs e)
        {
            if (label1.Font.Size - 2 > 0)
            {
                label1.Font = new Font(label1.Font.FontFamily, label1.Font.Size - 2);
            }
        }
    }
}