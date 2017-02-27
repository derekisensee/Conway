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
            b.printBoard();
        }
    }
}
