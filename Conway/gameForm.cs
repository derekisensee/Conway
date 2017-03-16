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
        public Backend b;
        Boolean paused;

        public gameForm()
        {
            InitializeComponent();
            b = new Backend();
            paused = false;
            //stepTimer.Stop(); // TODO: Delibate if we want this or not.
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            b.UpdateBoard();
            int[,] board = b.GetBoard();
            int aliveCells = 0;
            String boardString = "";

            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i, j] == 0)
                        boardString += ". ";
                    else
                    {
                        aliveCells++;
                        boardString += "+";
                    }
                }
                boardString += "\n";
            }
            label1.Text = boardString;

            aliveCount.Text = aliveCells.ToString();
            generationsCount.Text = b.currentGeneration.ToString();
        }

        private void pause_Click(object sender, EventArgs e)
        {
            if (paused)
            {
                stepTimer.Start();
                paused = false;
            }
            else
            {
                stepTimer.Stop();
                paused = true;
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

        private void structurePlaceFormButton_Click(object sender, EventArgs e)
        {
            stepTimer.Stop();
            structurePlace sP = new structurePlace();
            sP.f = this; // gives structurePlace access to the 'b' backend
            sP.Show();
        }

        private void ClearBoard_Click(object sender, EventArgs e)
        {
            b.ClearBoard();
        }

        private void randomizerButton_Click(object sender, EventArgs e)
        {
            stepTimer.Stop();
            randomizer r = new randomizer();
            r.f = this;
            r.Show();
        }

        private void slowSpeedButton_Click(object sender, EventArgs e)
        {
            stepTimer.Interval = 500;
        }

        private void mediumSpeedButton_Click(object sender, EventArgs e)
        {
            stepTimer.Interval = 300;
        }

        private void fastSpeedButton_Click(object sender, EventArgs e)
        {
            stepTimer.Interval = 100;
        }

        private void fastestSpeedButton_Click(object sender, EventArgs e)
        {
            stepTimer.Interval = 1;
        }

        private void HistoryButton_Click(object sender, EventArgs e)
        {
            stepTimer.Stop();
            History h = new History()
            {
                f = this
            };
            h.Show();
        }
    }
}