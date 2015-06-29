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
using Еscape_from_the_labyrinth_of_death.Factories;
using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses;

namespace Еscape_from_the_labyrinth_of_death
{
    public partial class PlayingForm : Form
    {
        private List<PictureBox> _wallsList;
        private IPlayerFactory _factory = PlayerFactory.PLAYER_FACTORY;
        private IHumanPlayer _humanPlayer;

        public PlayingForm(string UserName, string CharName)
        {
            InitializeComponent();
            UpdateWallsList();
            NaPlayer.Text = UserName;
            CharPlayer.Text = CharName;
            this._humanPlayer = (IHumanPlayer)this._factory.Create(this.playerBox, this._wallsList, PlayerClass.Elf);
        }

        private void PlayingForm_Load(object sender, EventArgs e)
        {

        }

        private void PlayingForm_KeyDown(object sender, KeyEventArgs e)
        {
            //Rectangle rect = playerBox.Bounds;

            if (e.KeyCode == Keys.Left)
            {
                this._humanPlayer.MoveLeft();
            }

            if (e.KeyCode == Keys.Right)
            {
                this._humanPlayer.MoveRight();
            }

            if (e.KeyCode == Keys.Up)
            {
                this._humanPlayer.MoveUp();
            }

            if (e.KeyCode == Keys.Down)
            {
                this._humanPlayer.MoveDown();
            }
        }

        private void MoveLeft(Rectangle rect)
        {
            rect.X -= 5;
            if (HasColision(rect))
            {
                return;
            }
            this.playerBox.Bounds = rect;
        }

        private void MoveRight(Rectangle rect)
        {
            rect.X += 5;
            if (HasColision(rect))
            {
                return;
            }
            this.playerBox.Bounds = rect;
        }

        private void MoveDown(Rectangle rect)
        {
            rect.Y += 5;
            if (HasColision(rect))
            {
                return;
            }
            this.playerBox.Bounds = rect;
        }

        private void MoveUp(Rectangle rect)
        {
            rect.Y -= 5;
            if (HasColision(rect))
            {
                return;
            }
            this.playerBox.Bounds = rect;
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
            this.playerBox.Bounds = rect;

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

        private void player_Click(object sender, EventArgs e)
        {

        }
    }
}