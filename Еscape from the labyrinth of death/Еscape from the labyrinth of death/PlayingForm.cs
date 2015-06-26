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
        private List<PictureBox> _wallsList;

        public PlayingForm(string UserName, string CharName)
        {
            InitializeComponent();
            UpdateWallsList();
            NaPlayer.Text = UserName;
            CharPlayer.Text = CharName;
        }

        private void PlayingForm_Load(object sender, EventArgs e)
        {

        }

        private void PlayingForm_KeyDown(object sender, KeyEventArgs e)
        {
            Rectangle rect = player.Bounds;

            if (e.KeyCode == Keys.Left)
            {
                this.MoveLeft(rect);
            }

            if (e.KeyCode == Keys.Right)
            {
                this.MoveRight(rect);
            }

            if (e.KeyCode == Keys.Up)
            {
                this.MoveUp(rect);
            }

            if (e.KeyCode == Keys.Down)
            {
                this.MoveDown(rect);
            }
        }

        private void MoveLeft(Rectangle rect)
        {
            rect.X -= 5;
            if (HasColision(rect))
            {
                return;
            }
            this.player.Bounds = rect;
        }

        private void MoveRight(Rectangle rect)
        {
            rect.X += 5;
            if (HasColision(rect))
            {
                return;
            }
            this.player.Bounds = rect;
        }

        private void MoveDown(Rectangle rect)
        {
            rect.Y += 5;
            if (HasColision(rect))
            {
                return;
            }
            this.player.Bounds = rect;
        }

        private void MoveUp(Rectangle rect)
        {
            rect.Y -= 5;
            if (HasColision(rect))
            {
                return;
            }
            this.player.Bounds = rect;
        }

        private bool HasColision(Rectangle rect)
        {
            foreach (PictureBox wall in this._wallsList)
            {
                if (rect.IntersectsWith(wall.Bounds))
                {
                    return true;
                }
            }
            this.player.Bounds = rect;

            return false;
        }

        private void PlayingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void playingPn_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbDefense_Click(object sender, EventArgs e)
        {

        }

        private void lbAttack_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UpdateWallsList()
        {
            this._wallsList = new List<PictureBox>()
            {
                wall_1,
                wall_2,
                wall_3,
                wall_4,
                wall_5,
                wall_6,
                wall_7,
                wall_8,
                wall_9,
                wall_10,
                wall_11,
                wall_12,
                wall_13,
                wall_14,
                wall_15,
                wall_16,
                wall_17,
                wall_18,
                wall_19,
                wall_20,
                wall_21,
                wall_22,
                wall_23,
                wall_24,
                wall_25,
                wall_26,
                wall_27,
                wall_28,
                wall_29,
                wall_30,
                wall_31,
                wall_32,
                wall_33,
            };
        }

        private void labelCurrentlyEquiped_Click(object sender, EventArgs e)
        {
            Currently_Equiped currentlyEquiped = new Currently_Equiped();
            currentlyEquiped.ShowDialog();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}