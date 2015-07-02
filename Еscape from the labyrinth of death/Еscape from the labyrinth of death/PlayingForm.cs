using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses;
using Еscape_from_the_labyrinth_of_death.Interfaces;
using Еscape_from_the_labyrinth_of_death.Factories;

namespace Еscape_from_the_labyrinth_of_death
{
    public partial class PlayingForm : Form
    {
        private readonly IPlayerFactory _playerFactory = PlayerFactory.PLAYER_FACTORY;
        private List<PictureBox> _wallsPBList;
        private List<PictureBox> _enemiesPBList;
        private List<INpcPlayer> _enemiesList;
        private IHumanPlayer _player;

        public PlayingForm(string UserName, string CharName)
        {
            InitializeComponent();

            this.UpdateWallsList();
            this.UpdateEnemiesList();

            NaPlayer.Text = UserName;
            CharPlayer.Text = CharName;

            this.InitializeEnemies();
            this.InitializePlayer();

            this.UpdateLevelLabel();
        }

        private void PlayingForm_Load(object sender, EventArgs e)
        {

        }

        private void PlayingForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                this._player.MoveLeft();
            }

            if (e.KeyCode == Keys.Right)
            {
                this._player.MoveRight();
            }

            if (e.KeyCode == Keys.Up)
            {
                this._player.MoveUp();
            }

            if (e.KeyCode == Keys.Down)
            {
                this._player.MoveDown();
            }

            this.UpdateLevelLabel();
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
            this._wallsPBList = new List<PictureBox>()
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

        private void UpdateEnemiesList()
        {
            this._enemiesPBList = new List<PictureBox>()
            {
                this.EvilHobbit1PB,
                this.EvilHobbit2PB,
                this.EvilElf1PB,
                this.EvilElf2PB,
                this.EvilKnight1PB,
                this.EvilKnight2PB,
                this.EvilMask1PB,
                this.EvilMask2PB,
                this.EvilDragon1PB,
                this.EvilDragon2PB,
                this.BossDragonflyPB,
                this.BossEggPB,
                this.BossWarriorPB,
            };
        }

        private void InitializeEnemies()
        {
            this._enemiesList = new List<INpcPlayer>(this._enemiesPBList.Count)
            {
                (INpcPlayer)this._playerFactory.Create(this.EvilHobbit1PB, this._wallsPBList, null, 
                    PlayerClass.EvilHobbit, null),
                (INpcPlayer)this._playerFactory.Create(this.EvilHobbit2PB, this._wallsPBList, null,
                    PlayerClass.EvilHobbit, null),
                (INpcPlayer)this._playerFactory.Create(this.EvilElf1PB, this._wallsPBList, null,
                    PlayerClass.EvilElf, null),
                (INpcPlayer)this._playerFactory.Create(this.EvilElf2PB, this._wallsPBList, null,
                    PlayerClass.EvilElf, null),
                (INpcPlayer)this._playerFactory.Create(this.EvilKnight1PB, this._wallsPBList, null,
                    PlayerClass.EvilKnight, null),
                (INpcPlayer)this._playerFactory.Create(this.EvilKnight2PB, this._wallsPBList, null,
                    PlayerClass.EvilKnight, null),
                (INpcPlayer)this._playerFactory.Create(this.EvilMask1PB, this._wallsPBList, null,
                    PlayerClass.EvilMask, null),
                (INpcPlayer)this._playerFactory.Create(this.EvilMask2PB, this._wallsPBList, null,
                    PlayerClass.EvilMask, null),
                (INpcPlayer)this._playerFactory.Create(this.EvilDragon1PB, this._wallsPBList, null,
                    PlayerClass.EvilDragon, null),
                (INpcPlayer)this._playerFactory.Create(this.EvilDragon2PB, this._wallsPBList, null,
                    PlayerClass.EvilDragon, null),
                (INpcPlayer)this._playerFactory.Create(this.BossDragonflyPB, this._wallsPBList, null,
                    PlayerClass.BossDragonfly, null),
                (INpcPlayer)this._playerFactory.Create(this.BossEggPB, this._wallsPBList, null,
                    PlayerClass.BossEgg, null),
                (INpcPlayer)this._playerFactory.Create(this.BossWarriorPB, this._wallsPBList, null,
                    PlayerClass.BossWarrior, null),
            };
        }

        private void InitializePlayer()
        {
            this._player = (IHumanPlayer)this._playerFactory.Create(this.playerPB, 
                this._wallsPBList,
                this._enemiesList,
                PlayerClass.Knight,
                NaPlayer.Text);
        }

        private void UpdateLevelLabel()
        {
            this.labelLvNumber.Text = this._player.Level.ToString();
        }

        private void labelCurrentlyEquiped_Click(object sender, EventArgs e)
        {
            Currently_Equiped currentlyEquiped = new Currently_Equiped(this._player);
            currentlyEquiped.ShowDialog();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            HelpForm helpF = new HelpForm();
            helpF.ShowDialog();
        }

        private void player_Click(object sender, EventArgs e)
        {

        }
    }
}