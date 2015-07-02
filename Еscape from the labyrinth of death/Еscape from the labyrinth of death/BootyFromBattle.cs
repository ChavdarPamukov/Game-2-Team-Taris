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
    public partial class BootyFromBattle : Form
    {
        private readonly IHumanPlayer _human;
        private readonly INpcPlayer _enemy;

        public BootyFromBattle(IHumanPlayer human, INpcPlayer enemy)
        {
            InitializeComponent();

            this._human = human;
            this._enemy = enemy;

            this.UpdateLabels();

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void BootyFromBattle_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.SwapPotions();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.SwapWeapons();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.SwapArmors();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.SwapShields();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.SwapHelmets();
        }

        private void SwapPotions()
        {
            IItem tmp = this._human.Inventory[4];
            this._human.Inventory[4] = this._enemy.Inventory[4];
            this._enemy.Inventory[4] = tmp;

            this.UpdateLabels();
        }

        private void SwapWeapons()
        {
            IItem tmp = this._human.Inventory[0];
            this._human.Inventory[0] = this._enemy.Inventory[0];
            this._enemy.Inventory[0] = tmp;

            this.UpdateLabels();
        }

        private void SwapArmors()
        {
            IItem tmp = this._human.Inventory[1];
            this._human.Inventory[1] = this._enemy.Inventory[1];
            this._enemy.Inventory[1] = tmp;

            this.UpdateLabels();
        }

        private void SwapShields()
        {
            IItem tmp = this._human.Inventory[2];
            this._human.Inventory[2] = this._enemy.Inventory[2];
            this._enemy.Inventory[2] = tmp;

            this.UpdateLabels();
        }

        private void SwapHelmets()
        {
            IItem tmp = this._human.Inventory[3];
            this._human.Inventory[3] = this._enemy.Inventory[3];
            this._enemy.Inventory[3] = tmp;

            this.UpdateLabels();
        }

        private void UpdateLabels()
        {
            this.UpdateHumanLabels();
            this.UpdateEnemyLabels();
        }

        private void UpdateHumanLabels()
        {
            this.UpdateHumanPotion();
            this.UpdateHumanWeapon();
            this.UpdateHumanArmor();
            this.UpdateHumanShield();
            this.UpdateHumanHelmet();
        }

        private void UpdateEnemyLabels()
        {
            this.UpdateEnemyPotion();
            this.UpdateEnemyWeapon();
            this.UpdateEnemyArmor();
            this.UpdateEnemyShield();
            this.UpdateEnemyHelmet();
        }

        private void UpdateEnemyPotion()
        {
            if (this._enemy.Inventory[4] != default(IItem))
            {
                this.label15.Text = this._enemy.Inventory[4].ItemName;
                this.label14.Text = this._enemy.Inventory[4].ToString();
            }
            else
            {
                this.label15.Text = "Not equiped";
                this.label14.Text = "";
            }
        }

        private void UpdateEnemyWeapon()
        {
            if (this._enemy.Inventory[0] != default(IItem))
            {
                this.label17.Text = this._enemy.Inventory[0].ItemName;
                this.label16.Text = this._enemy.Inventory[0].ToString();
            }
            else
            {
                this.label17.Text = "Not equiped";
                this.label16.Text = "";
            }
        }

        private void UpdateEnemyArmor()
        {
            if (this._enemy.Inventory[1] != default(IItem))
            {
                this.label19.Text = this._enemy.Inventory[1].ItemName;
                this.label18.Text = this._enemy.Inventory[1].ToString();
            }
            else
            {
                this.label19.Text = "Not equiped";
                this.label18.Text = "";
            }
        }

        private void UpdateEnemyShield()
        {
            if (this._enemy.Inventory[2] != default(IItem))
            {
                this.label21.Text = this._enemy.Inventory[2].ItemName;
                this.label20.Text = this._enemy.Inventory[2].ToString();
            }
            else
            {
                this.label21.Text = "Not equiped";
                this.label20.Text = "";
            }
        }

        private void UpdateEnemyHelmet()
        {
            if (this._enemy.Inventory[3] != default(IItem))
            {
                this.label23.Text = this._enemy.Inventory[3].ItemName;
                this.label22.Text = this._enemy.Inventory[3].ToString();
            }
            else
            {
                this.label23.Text = "Not equiped";
                this.label22.Text = "";
            }
        }

        private void UpdateHumanPotion()
        {
            if (this._human.Inventory[4] != default(IItem))
            {
                this.label5.Text = this._human.Inventory[4].ItemName;
                this.label4.Text = this._human.Inventory[4].ToString();
            }
            else
            {
                this.label5.Text = "Not Equiped";
                this.label4.Text = "";
            }
        }

        private void UpdateHumanWeapon()
        {
            if (this._human.Inventory[0] != default(IItem))
            {
                this.label7.Text = this._human.Inventory[0].ItemName;
                this.label6.Text = this._human.Inventory[0].ToString();
            }
            else
            {
                this.label7.Text = "Not Equiped";
                this.label6.Text = "";
            }
        }

        private void UpdateHumanArmor()
        {
            if (this._human.Inventory[1] != default(IItem))
            {
                this.label9.Text = this._human.Inventory[1].ItemName;
                this.label8.Text = this._human.Inventory[1].ToString();
            }
            else
            {
                this.label9.Text = "Not Equiped";
                this.label8.Text = "";
            }
        }

        private void UpdateHumanShield()
        {
            if (this._human.Inventory[2] != default(IItem))
            {
                this.label11.Text = this._human.Inventory[2].ItemName;
                this.label10.Text = this._human.Inventory[2].ToString();
            }
            else
            {
                this.label11.Text = "Not Equiped";
                this.label10.Text = "";
            }
        }

        private void UpdateHumanHelmet()
        {
            if (this._human.Inventory[3] != default(IItem))
            {
                this.label13.Text = this._human.Inventory[3].ItemName;
                this.label12.Text = this._human.Inventory[3].ToString();
            }
            else
            {
                this.label13.Text = "Not Equiped";
                this.label12.Text = "";
            }
        }
    }
}
