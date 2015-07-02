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
using Еscape_from_the_labyrinth_of_death.Exceptions;

namespace Еscape_from_the_labyrinth_of_death
{
    enum PlayerType
    {
        Human,
        Enemy,
    }

    enum Action
    {
        Attack,
        Heal,
        Forfeit,
    }

    public partial class Fighting : Form
    {
        private readonly IHumanPlayer _human;
        private readonly INpcPlayer _enemy;
        private readonly byte _defaultActionCount;

        private int _humanHealth;
        private int _enemyHealth;

        public Fighting(IHumanPlayer human, INpcPlayer enemy)
        {
            InitializeComponent();

            this._human = human;
            this._enemy = enemy;

            this._humanHealth = this._human.Health;
            this._enemyHealth = this._enemy.Health;

            this._defaultActionCount = 2;

            this.UpdateHealthPoints();
            this.SetImages();
            this.SetNames();
            this.UpdateActionCount(this._defaultActionCount);
        }

        private void Fighting_Load(object sender, EventArgs e)
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

        private void UpdateActionCount(byte actionCount)
        {
            this.ActionCount.Text = actionCount.ToString();
        }

        private void buttonHeal_EventHandler(object sender, EventArgs e)
        {
            if (this._human.Potion != default(IItem))
            {
                this._humanHealth += this._human.Potion.BonusToHealth;
                this._human.Potion = default(IItem);
            }

            this.DecrementActionCount();
        }

        private void buttonAttack_EventHandler(object sender, EventArgs e)
        {
            int damage = (this._human.Attack * this._human.Intelligence) - this._enemy.Defence;

            if (damage <= 0)
            {
                return;
            }

            this._enemyHealth -= damage;

            if (this.CharacterIsDead(PlayerType.Enemy))
            {
                this.VictorySequence();
                this.Close();
            }

            this.UpdateHealthPoints();
            this.DecrementActionCount();
        }

        private void butonForfeit_eventHandler(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool CharacterIsDead(PlayerType playerType)
        {
            switch (playerType)
            {
                case PlayerType.Human:
                    return this._humanHealth <= 0;
                case PlayerType.Enemy:
                    return this._enemyHealth <= 0;
                default:
                    throw new InvalidPlayerTypeException("Invalid player type: " + playerType.ToString());
            }
        }

        private void VictorySequence()
        {
            this._enemy.IsDead = true;
            if (this._enemy.IsBoss)
            {
                this.GameOverWinSequence();
            }

            this.AddExperience();

            BootyFromBattle bootyForm = new BootyFromBattle(this._human, this._enemy);
            bootyForm.ShowDialog();
        }

        private void DecrementActionCount()
        {
            int currentCount = int.Parse(this.ActionCount.Text);
            currentCount -= 1;
            if (currentCount <= 0)
            {
                this.DeactivateButtons();
                this.EnemyAttack();
                this.EnemyAttack();
                this.ActivateButtons();
                currentCount = 2;
                this.UpdateHealthPoints();
            }

            this.ActionCount.Text = currentCount.ToString();
        }

        private void DeactivateButtons()
        {
            this.buttonAttack.Enabled = false;
            this.buttonHeal.Enabled = false;
            this.buttonForfeit.Enabled = false;
        }

        private void ActivateButtons()
        {
            this.buttonAttack.Enabled = true;
            this.buttonHeal.Enabled = true;
            this.buttonForfeit.Enabled = true;
        }

        private void EnemyAttack()
        {
            int damage = (this._enemy.Attack + this._enemy.Intelligence) - this._human.Defence;

            if (damage <= 0)
            {
                return;
            }

            this._humanHealth -= damage;
            this.UpdateHealthPoints();

            if (this.CharacterIsDead(PlayerType.Human))
            {
                this.GameOverLossSequence();
            }

            this.UpdateHealthPoints();
        }

        private void GameOverLossSequence()
        {
            this._human.IsDead = true;
            Loser loserForm = new Loser();
            loserForm.ShowDialog();
        }

        private void GameOverWinSequence()
        {
            Winner winner = new Winner();
            winner.ShowDialog();
        }

        private void AddExperience()
        {
            //int expGained = (this._enemy.Level * 10) / this._human.Level;
            int expGained = this._enemy.Level / this._human.Level;
            this._human.Experience += expGained;
        }
    }
}
