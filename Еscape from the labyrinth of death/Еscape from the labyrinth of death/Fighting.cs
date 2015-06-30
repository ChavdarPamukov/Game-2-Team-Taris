using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Еscape_from_the_labyrinth_of_death.Interfaces;

namespace Еscape_from_the_labyrinth_of_death
{
    public partial class Fighting : Form
    {
        private readonly IHumanPlayer _human;
        private readonly INpcPlayer _enemy;

        public Fighting(IHumanPlayer human, INpcPlayer enemy)
        {
            InitializeComponent();

            this._human = human;
            this._enemy = enemy;
        }

        private void Fighting_Load(object sender, EventArgs e)
        {

        }
    }
}
