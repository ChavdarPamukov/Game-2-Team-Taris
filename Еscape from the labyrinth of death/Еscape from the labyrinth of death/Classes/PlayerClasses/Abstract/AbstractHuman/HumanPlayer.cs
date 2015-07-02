using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Еscape_from_the_labyrinth_of_death.Exceptions;
using Еscape_from_the_labyrinth_of_death.Interfaces;
using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses;
using Еscape_from_the_labyrinth_of_death.Classes.PlayerClasses.Abstract.AbstractGeneric;

namespace Еscape_from_the_labyrinth_of_death.Classes.PlayerClasses.Abstract.AbstractHuman
{
    public abstract class HumanPlayer : GenericPlayer, IHumanPlayer
    {
        private byte _level;
        private int _experience;
        private int _nextLevelAt;
        private IItem _potion;
        private List<PictureBox> _pictureBoxListWalls;
        private List<INpcPlayer> _enemiesList;

        public HumanPlayer(byte health, byte attack, byte defence, byte intelligence,
            PictureBox pictureBoxPlayer, PlayerClass playerClass, List<PictureBox> pictureBoxListWalls,
            List<INpcPlayer> enemiesList, string name, Image smallImage, Image largeImage)
            : base(health, attack, defence, intelligence, pictureBoxPlayer, true, 
            playerClass, name, smallImage, largeImage)
        {
            this._level = 1;
            this._experience = 1;
            this._nextLevelAt = 10;
            this._potion = null;
            this.PictureBoxListWalls = pictureBoxListWalls;
            this._enemiesList = enemiesList;
        }

        public override byte Level
        {
            set
            {
                if (this.LevelIsValid(value))
                {
                    this._level = value;
                }
            }
            get
            {
                return this._level;
            }
        }

        public int Experience
        {
            set
            {
                if (this.WillLevelUp(value))
                {
                    this.Level += 1;
                    this._experience = value;
                    this.AdjustNextLevelValue();
                    this.AddNewLevelBonuses();
                }
                else
                {
                    this._experience = this.Experience + value;
                }
            }
            get
            {
                return this._experience;
            }
        }

        public void MoveUp()
        {
            Rectangle r = this.PictureBoxPlayer.Bounds;
            r.Y -= 5;
            
            if (HitWall(r))
            {
                return;
            }

            this.CheckIfEnemyIsReached(r);

            this.PictureBoxPlayer.Bounds = r;
        }

        public void MoveRight()
        {
            Rectangle r = this.PictureBoxPlayer.Bounds;
            r.X += 5;

            if (HitWall(r))
            {
                return;
            }

            this.CheckIfEnemyIsReached(r);

            this.PictureBoxPlayer.Bounds = r;
        }

        public void MoveDown()
        {
            Rectangle r = this.PictureBoxPlayer.Bounds;
            r.Y += 5;

            if (HitWall(r))
            {
                return;
            }

            this.CheckIfEnemyIsReached(r);

            this.PictureBoxPlayer.Bounds = r;
        }

        public void MoveLeft()
        {
            Rectangle r = this.PictureBoxPlayer.Bounds;
            r.X -= 5;

            if (HitWall(r))
            {
                return;
            }

            this.CheckIfEnemyIsReached(r);

            this.PictureBoxPlayer.Bounds = r;
        }

        public IItem Potion
        {
            set
            {
                this._potion = value;
            }
            get
            {
                return this._potion;
            }
        }

        public void AddToInventory(IItem item)
        {
            this.CheckIfItemIsValid(item);
            this.Inventory.Add(item);
        }

        public List<PictureBox> PictureBoxListWalls
        {
            set
            {
                this._pictureBoxListWalls = value;
            }
            get
            {
                return this._pictureBoxListWalls;
            }
        }

        private bool LevelIsValid(byte level)
        {
            return level <= 25;
        }

        private void AdjustNextLevelValue()
        {
            int tmp = this._nextLevelAt + ((int)Math.Pow(this.Experience, 2));

            if (tmp <= 0)
            {
                throw new UnreachableLevelException("Something went terribly wrong with the experience");
            }

            this._nextLevelAt = this._nextLevelAt + ((int)Math.Pow(this.Experience, 2));
        }

        private bool WillLevelUp(int value)
        {
            return this.LevelIsValid((byte)(this.Level + 1)) &&
                value >= this._nextLevelAt;
        }

        private void CheckIfItemIsValid(IItem item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("Item can't be null");
            }
        }

        private bool HitWall(Rectangle rect)
        {
            foreach (PictureBox wall in this.PictureBoxListWalls)
            {
                if (rect.IntersectsWith(wall.Bounds))
                {
                    return true;
                }
            }

            return false;
        }

        private void CheckIfEnemyIsReached(Rectangle rect)
        {
            foreach (INpcPlayer enemy in this._enemiesList)
            {
                if (!(enemy.IsDead) && 
                    rect.IntersectsWith(enemy.PictureBoxPlayer.Bounds))
                {
                    this.BeginCombat(this, enemy);
                }
            }
        }

        private void BeginCombat(IHumanPlayer human, INpcPlayer enemy)
        {
            Fighting fightingForm = new Fighting(human, enemy);
            fightingForm.ShowDialog();

            if (this.IsDead == true)
            {
                Loser loserForm = new Loser();
                loserForm.ShowDialog();
            }
        }

        private void AddNewLevelBonuses()
        {
            this.Attack += 10;
            this.Defence += 10;
            this.Intelligence += 10;
        }
    }
}
