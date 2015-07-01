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
    private enum PlayerType
    {
        Human,
        Enemy,
    }

    private enum Action
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

        private byte _humanHealth;
        private byte _enemyHealth;

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

            this.BeginCombat();
        }

        private void Fighting_Load(object sender, EventArgs e)
        {

        }

        private void BeginCombat()
        {
            PlayerType playerOnTurn = PlayerType.Human;

            while (!(this.HumanIsDead() && !(this.EnemyIsDead())))
            {
                this.UpdateActionCount(this._defaultActionCount);
                if (playerOnTurn == PlayerType.Human)
                {
                    this.DoHumanTurn();
                    playerOnTurn = PlayerType.Enemy;
                }
                else
                {
                    this.DoEnemyTurn();
                    playerOnTurn = PlayerType.Human;
                }
            }
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

        private void UpdateActionCount(byte count)
        {
            this.ActionCount.Text = count.ToString();
        }

        private bool HumanIsDead()
        {
            return this._human.IsDead;
        }

        private bool EnemyIsDead()
        {
            return this._enemy.IsDead;
        }

        private void DoHumanTurn()
        {
            byte actionCount = this._defaultActionCount;
            while (actionCount > 0)
            {
                Action action = this.WaitForPlayerActionDecision();
                this.DoAction(action, PlayerType.Human);

                if (this.EnemyIsDead())
                {
                    if (this._enemy.IsBoss)
                    {
                        this.Close();
                    }
                }

                actionCount--;
                this.UpdateActionCount(actionCount);
            }
        }

        private Action WaitForPlayerActionDecision()
        {
            this.buttonHeal.Click += buttonHeal_EventHandler;
            this.buttonForfeit.
            this.buttonAttack.Click += buttonAttack_EventHandler;
            this.buttonForfeit.Click += butonForfeit_eventHandler;
        }

        private void buttonHeal_EventHandler(object sender, EventArgs e)
        {

        }

        private void buttonAttack_EventHandler(object sender, EventArgs e)
        {

        }

        private void butonForfeit_eventHandler(object sender, EventArgs e)
        {

        }
    }
}
