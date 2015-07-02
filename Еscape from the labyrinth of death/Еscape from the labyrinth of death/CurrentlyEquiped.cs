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
    public partial class Currently_Equiped : Form
    {
        private readonly IHumanPlayer _player;

        public Currently_Equiped(IHumanPlayer player)
        {
            InitializeComponent();

            this._player = player;

            this.UpdateItems();
            this.UpdateStats();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.SwapPotion();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.SwapPotion();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.SwapWeapon();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.SwapWeapon();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.SwapArmor();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.SwapArmor();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.SwapShield();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.SwapShield();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.SwapHelmet();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.SwapHelmet();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void Currently_Equiped_Load(object sender, EventArgs e)
        {

        }

        private void UpdateItems()
        {
            this.UpdatePotion();
            this.UpdateWeapon();
            this.UpdateArmor();
            this.UpdateShield();
            this.UpdateHelmet();

            this.UpdateEquipedPotion();
            this.UpdateEquipedWeapon();
            this.UpdateEquipedArmor();
            this.UpdateEquipedShield();
            this.UpdateEquipedHelmet();
        }

        private void UpdateEquipedPotion()
        {
            if (this._player.Potion != default(IItem))
            {
                this.label29.Text = this._player.Potion.ItemName;
                this.label8.Text = this._player.Potion.ToString();
            }
            else
            {
                this.label29.Text = "Not Equipped";
                this.label8.Text = "";
            }
        }

        private void UpdateEquipedWeapon()
        {
            if (this._player.Weapon != default(IItem))
            {
                this.label28.Text = this._player.Weapon.ItemName;
                this.label9.Text = this._player.Weapon.ToString();
            }
            else
            {
                this.label28.Text = "Not Equiped";
                this.label9.Text = "";
            }
        }

        private void UpdateEquipedArmor()
        {
            if (this._player.BodyArmor != default(IItem))
            {
                this.label27.Text = this._player.BodyArmor.ItemName;
                this.label10.Text = this._player.BodyArmor.ToString();
            }
            else
            {
                this.label27.Text = "Not Equiped";
                this.label10.Text = "";
            }
        }

        private void UpdateEquipedShield()
        {
            if (this._player.Shield != default(IItem))
            {
                this.label26.Text = this._player.Shield.ItemName;
                this.label11.Text = this._player.Shield.ToString();
            }
            else
            {
                this.label26.Text = "Not equiped";
                this.label11.Text = "";
            }
        }

        private void UpdateEquipedHelmet()
        {
            if (this._player.Helmet != default(IItem))
            {
                this.label25.Text = this._player.Helmet.ItemName;
                this.label12.Text = this._player.Helmet.ToString();
            }
            else
            {
                this.label25.Text = "Not Equiped";
                this.label12.Text = "";
            }
        }

        private void UpdatePotion()
        {
            if (this._player.Inventory[4] != default(IItem))
            {
                this.label24.Text = this._player.Inventory[4].ItemName;
                this.label1.Text = this._player.Inventory[4].ToString();
            }
            else
            {
                this.label24.Text = "Not Equipped";
                this.label1.Text = "";
            }
        }

        private void UpdateWeapon()
        {
            if (this._player.Inventory[0] != default(IItem))
            {
                this.label23.Text = this._player.Inventory[0].ItemName;
                this.label2.Text = this._player.Inventory[0].ToString();
            }
            else
            {
                this.label23.Text = "Not Equiped";
                this.label2.Text = "";
            }
        }

        private void UpdateArmor()
        {
            if (this._player.Inventory[1] != default(IItem))
            {
                this.label22.Text = this._player.Inventory[1].ItemName;
                this.label3.Text = this._player.Inventory[1].ToString();
            }
            else
            {
                this.label22.Text = "Not Equiped";
                this.label3.Text = "";
            }
        }

        private void UpdateShield()
        {
            if (this._player.Inventory[2] != default(IItem))
            {
                this.label21.Text = this._player.Inventory[2].ItemName;
                this.label4.Text = this._player.Inventory[2].ToString();
            }
            else
            {
                this.label21.Text = "Not equiped";
                this.label4.Text = "";
            }
        }

        private void UpdateHelmet()
        {
            if (this._player.Inventory[3] != default(IItem))
            {
                this.label20.Text = this._player.Inventory[3].ItemName;
                this.label5.Text = this._player.Inventory[3].ToString();
            }
            else
            {
                this.label20.Text = "Not Equiped";
                this.label5.Text = "";
            }
        }

        private void SwapPotion()
        {
            IItem tmp = this._player.Inventory[4];
            this._player.Inventory[4] = this._player.Potion;
            this._player.Potion = tmp;

            this.UpdatePotion();
            this.UpdateEquipedPotion();

            this.UpdateStats();
        }

        private void SwapWeapon()
        {
            IItem tmp = this._player.Inventory[0];
            this._player.Inventory[0] = this._player.Weapon;
            this._player.Weapon = tmp;

            this.UpdateWeapon();
            this.UpdateEquipedWeapon();

            this.UpdateStats();
        }

        private void SwapArmor()
        {
            IItem tmp = this._player.Inventory[1];
            this._player.Inventory[1] = this._player.BodyArmor;
            this._player.BodyArmor = tmp;

            this.UpdateArmor();
            this.UpdateEquipedArmor();

            this.UpdateStats();
        }

        private void SwapHelmet()
        {
            IItem tmp = this._player.Inventory[3];
            this._player.Inventory[3] = this._player.Helmet;
            this._player.Helmet = tmp;

            this.UpdateHelmet();
            this.UpdateEquipedHelmet();

            this.UpdateStats();
        }

        private void SwapShield()
        {
            IItem tmp = this._player.Inventory[2];
            this._player.Inventory[2] = this._player.Shield;
            this._player.Shield = tmp;

            this.UpdateShield();
            this.UpdateEquipedShield();

            this.UpdateStats();
        }

        private void UpdateStats()
        {
            this.label16.Text = this._player.Health.ToString();
            this.label17.Text = this._player.Attack.ToString();
            this.label18.Text = this._player.Defence.ToString();
        }
    }
}
