using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses;

namespace Еscape_from_the_labyrinth_of_death.Classes.PlayerClasses.Abstract.AbstractNpc
{
    public abstract class BossNpcPlayer : NpcPlayer
    {
        public BossNpcPlayer(byte health, byte attack, byte defence, byte intelligence,
            PictureBox pictureBoxPlayer, byte level, uint respawnInterval, PlayerClass playerClass)
            : base(health, attack, defence, intelligence, pictureBoxPlayer, level, respawnInterval, playerClass, true)
        {
            
        }

        public override bool IsDead
        {
            get
            {
                return base.IsDead;
            }
            set
            {
                base.IsDead = value;
            }
        }
    }
}
