using System;
using System.Collections;
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
    public partial class History : Form
    {
        public gameForm f;
        ArrayList boardHistory;
        List<int> generationHistory;
        List<int> aliveHistory;

        public History()
        {
            InitializeComponent();
        }

        private void History_FormClosing(object sender, FormClosingEventArgs e)
        {
            f.stepTimer.Start();
        }

        private void History_Load(object sender, EventArgs e)
        {
            boardHistory = f.b.GetHistory();
            generationHistory = f.b.GetGenerationHistory();
            aliveHistory = f.b.GetAliveHistory();
            for (int i = 0; i < generationHistory.Count; i++) {
                historyChart.Series["Series1"].Points.Add(generationHistory[i], aliveHistory[i]);
            }
        }
    }
}
