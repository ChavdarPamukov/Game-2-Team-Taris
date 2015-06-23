using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Еscape_from_the_labyrinth_of_death.Interfaces;

namespace Еscape_from_the_labyrinth_of_death.Classes.PlayerClasses.Abstract.AbstractGeneric
{
    abstract class GenericPlayer : IPlayer
    {
        private byte _health;
        private byte _attack;
        private byte _defence;
        private byte _intelligence;
        private PictureBox _pictureBoxPlayer;
        private List<IItem> _inventory;
        private IItem _bodyArmor;
        private IItem _helmet;
        private IItem _shield;
        private IItem _weapon;
        private bool _isDead;
        private readonly bool _isHuman;
        private readonly PlayerType _playerType;

        public GenericPlayer(byte health, byte attack, byte defence, byte intelligence,
            PictureBox pictureBoxPlayer, bool isHuman, PlayerType playerType)
        {
            this.Health = health;
            this.Attack = attack;
            this.Defence = defence;
            this.Intelligence = intelligence;
            this.PictureBoxPlayer = pictureBoxPlayer;
            this._isHuman = IsHuman;
            this._playerType = playerType;
            this.IsDead = IsDead;
            this._inventory = new List<IItem>();
            this._bodyArmor = default(IItem);
            this._helmet = default(IItem);
            this._shield = default(IItem);
            this._weapon = default(IItem);
        }

        public abstract byte Level { set; get; }

        public byte Health
        {
            set
            {
                this._health = value;
            }
            get
            {
                return this._health;
            }
        }

        public byte Attack
        {
            set
            {
                this._attack = value;
            }
            get
            {
                return this._attack;
            }
        }

        public byte Defence
        {
            set
            {
                this._defence = value;
            }
            get
            {
                return this._defence;
            }
        }

        public byte Intelligence
        {
            set
            {
                this._intelligence = value;
            }
            get
            {
                return this._intelligence;
            }
        }

        public PictureBox PictureBoxPlayer
        {
            set
            {
                this._pictureBoxPlayer = value;
            }
            get
            {
                return this._pictureBoxPlayer;
            }
        }

        public List<IItem> Inventory
        {
            set
            {
                this._inventory = value;
            }
            get
            {
                return this._inventory;
            }
        }

        public IItem BodyArmor
        {
            set
            {
                this._bodyArmor = value;
            }
            get
            {
                return this._bodyArmor;
            }
        }

        public IItem Helmet
        {
            set
            {
                this._helmet = value;
            }
            get
            {
                return this._helmet;
            }
        }

        public IItem Shield
        {
            set
            {
                this._shield = value;
            }
            get
            {
                return this._shield;
            }
        }

        public IItem Weapon
        {
            set
            {
                this._weapon = value;
            }
            get
            {
                return this._weapon;
            }
        }

        public bool IsDead
        {
            set
            {
                this._isDead = value;
            }
            get
            {
                return this._isDead;
            }
        }

        public bool IsHuman
        {
            get
            {
                return this._isHuman;
            }
        }

        public PlayerType PlayerType
        {
            get
            {
                return this._playerType;
            }
        }
    }
}
