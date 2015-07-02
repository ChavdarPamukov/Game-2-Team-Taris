using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Еscape_from_the_labyrinth_of_death
{
    public partial class Loser : Form
    {
        public Loser()
        {
            InitializeComponent();
        }

        private void Loser_Load(object sender, EventArgs e)
        {

        }

        private void Loser_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
