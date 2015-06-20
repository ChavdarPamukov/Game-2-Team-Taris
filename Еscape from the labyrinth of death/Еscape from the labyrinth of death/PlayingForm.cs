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
    public partial class PlayingForm : Form
    {
        private bool left;
        private bool right;
        private bool up;
        private bool down;

        public PlayingForm(string UserName, string CharName)
        {
            InitializeComponent();
            NaPlayer.Text = UserName;
            CharPlayer.Text = CharName;
        }

        private void PlayingForm_Load(object sender, EventArgs e)
        {

        }

        private void PlayingForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                player.Left -= 5;
            }

            if (e.KeyCode == Keys.Right)
            {
                player.Left += 5;
            }

            if (e.KeyCode == Keys.Up)
            {
                player.Top -= 5;
            }

            if (e.KeyCode == Keys.Down)
            {
                player.Top += 5;
            }

            Collisions();
        }

        public void Collisions()
        {
            if (player.Bounds.IntersectsWith(wall_1.Bounds))
            {
                player.Left -= 5;
                player.Top -= 5;
            }

            else if (player.Bounds.IntersectsWith(wall_2.Bounds))
            {
                player.Left -= 5;
                player.Top -= 5;
            }
        }

        private void PlayingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbAttack_Click(object sender, EventArgs e)
        {

        }
    }
}
