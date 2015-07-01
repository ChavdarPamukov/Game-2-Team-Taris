using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Еscape_from_the_labyrinth_of_death.Interfaces;
using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses;

namespace Еscape_from_the_labyrinth_of_death.Classes.PlayerClasses.Abstract.AbstractGeneric
{
    public abstract class GenericPlayer : IPlayer
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
        private readonly PlayerClass _playerClass;
        private string _name;
        private Image _smallImage;
        private Image _largeImage;

        public GenericPlayer(byte health, byte attack, byte defence, byte intelligence,
            PictureBox pictureBoxPlayer, bool isHuman, PlayerClass playerClass, 
            string name, Image smallImage, Image largeImage)
        {
            this.Health = health;
            this.Attack = attack;
            this.Defence = defence;
            this.Intelligence = intelligence;
            this.PictureBoxPlayer = pictureBoxPlayer;
            this._isHuman = IsHuman;
            this._playerClass = playerClass;
            this.IsDead = IsDead;
            this._inventory = new List<IItem>();
            this._bodyArmor = default(IItem);
            this._helmet = default(IItem);
            this._shield = default(IItem);
            this._weapon = default(IItem);
            this.Name = name;
            this.SmallImage = smallImage;
            this.LargeImage = largeImage;
            this.PictureBoxPlayer.Image = this.SmallImage;
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
                this.CalculateBonuses();
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
                this.CalculateBonuses();
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
                this.CalculateBonuses();
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
                this.CalculateBonuses();
            }
            get
            {
                return this._weapon;
            }
        }

        public string Name
        {
            get
            {
                return this._name;
            }
            protected set
            {
                this._name = value;
            }
        }

        public Image SmallImage 
        {
            get 
            {
                return this._smallImage;
            }
            private set
            {
                this._smallImage = value;
            }
        }

        public Image LargeImage
        {
            get
            {
                return this._largeImage;
            }
            private set
            {
                this._largeImage = value;
            }
        }

        public virtual bool IsDead
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

        public PlayerClass PlayerClass
        {
            get
            {
                return this._playerClass;
            }
        }

        private void CalculateBonuses()
        {
            //BOnuses will be added to Health, Attack, Defence and Intelligence here.
            throw new NotImplementedException();
        }
    }
}
