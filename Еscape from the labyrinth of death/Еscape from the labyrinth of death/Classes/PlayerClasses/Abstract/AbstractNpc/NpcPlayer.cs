using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Еscape_from_the_labyrinth_of_death.Exceptions;
using Еscape_from_the_labyrinth_of_death.Interfaces;
using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses;
using Еscape_from_the_labyrinth_of_death.Classes.PlayerClasses.Abstract.AbstractGeneric;

namespace Еscape_from_the_labyrinth_of_death.Classes.PlayerClasses.Abstract.AbstractNpc
{
    public abstract class NpcPlayer : GenericPlayer, INpcPlayer
    {
        private readonly byte _level;
        private uint _respawnInterval;
        private uint _respawnCounter;
        private bool _isBoss;

        public NpcPlayer(byte health, byte attack, byte defence, byte intelligence,
            PictureBox pictureBoxPlayer, byte level, uint respawnInterval, PlayerClass playerClass, bool isBoss)
            : base(health, attack, defence, intelligence, pictureBoxPlayer, false, playerClass)
        {
            this._level = level;
            this.RespawnInterval = respawnInterval;
            this._respawnCounter = 0;
            this._isBoss = isBoss;
        }

        public override byte Level
        {
            set
            {
                return;
            }
            get
            {
                return this._level;
            }
        }

        public uint RespawnInterval
        {
            set
            {
                this._respawnInterval = value;
            }
            get
            {
                return this._respawnInterval;
            }
        }

        public void Respawn()
        {
            this.PictureBoxPlayer.Visible = true;
        }

        public override bool IsDead
        {
            get
            {
                return base.IsDead;
            }
            set
            {
                this.IsDead = value;
                if (this.IsDead == false)
                {
                    this.Respawn();
                }
                else
                {
                    this.BeginRespawnCount();
                }
            }
        }

        public bool IsBoss
        {
            get
            {
                return this._isBoss;
            }
        }

        private void BeginRespawnCount()
        {
            Thread counterThread = new Thread(RespawnCountdown);
            counterThread.Start();
        }

        private void RespawnCountdown()
        {
            while (this._respawnCounter < this.RespawnInterval)
            {
                this._respawnCounter++;
            }
            this.Respawn();
        }
    }
}
