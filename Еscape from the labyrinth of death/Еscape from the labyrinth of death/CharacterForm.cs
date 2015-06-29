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
    public partial class CharacterForm : Form
    {
        public CharacterForm()
        {
            InitializeComponent();
        }

        private void EfButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PlayingForm playf2 = new PlayingForm(NamePlayer1.Text, LbElf.Text);
            playf2.ShowDialog();
        }

        private void WiButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PlayingForm playf2 = new PlayingForm(NamePlayer2.Text, LbWizard.Text);
            playf2.ShowDialog();
        }

        private void WaButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PlayingForm playf2 = new PlayingForm(NamePlayer3.Text, LbWarrior.Text);
            playf2.ShowDialog();
        }

        private void CharacterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void CharacterForm_Load(object sender, EventArgs e)
        {

        }

        private void LbWizard_Click(object sender, EventArgs e)
        {

        }
    }
}