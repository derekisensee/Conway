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
    public partial class randomizer : Form
    {
        public gameForm f;
        public randomizer()
        {
            InitializeComponent();
        }

        private void randomize_Click(object sender, EventArgs e)
        {
            f.b.randomize(randomDensity.Value);
            Close();
        }

        private void randomizer_FormClosing(object sender, FormClosingEventArgs e)
        {
            f.stepTimer.Start();
        }
    }
}
