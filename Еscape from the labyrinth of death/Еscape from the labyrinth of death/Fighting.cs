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
        private byte _humanHealth;
        private byte _enemyHealth;

        public Fighting(IHumanPlayer human, INpcPlayer enemy)
        {
            InitializeComponent();

            this._human = human;
            this._enemy = enemy;

            this._humanHealth = this._human.Health;
            this._enemyHealth = this._enemy.Health;

            this.UpdateHealthPoints();
            this.SetImages();
            this.SetNames();
            this.BeginCombat();
        }

        private void Fighting_Load(object sender, EventArgs e)
        {

        }

        private void BeginCombat()
        {

        }

        private void UpdateHealthPoints()
        {
            this.PlayerHealthPoints.Text = this._humanHealth.ToString();
            this.EnemyHealthPoints.Text = this._enemyHealth.ToString();
        }

        private void SetNames()
        {
            this.HumanName.Text = this._human.Name;
            this.EnemyName.Text = this._enemy.Name;
        }

        private void SetImages()
        {
            this.pictureBoxPlayer.Image = this._human.LargeImage;
            this.pictureBoxEnemy.Image = this._enemy.LargeImage;
        }
    }
}
