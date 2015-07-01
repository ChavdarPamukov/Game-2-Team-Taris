using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses;
using Еscape_from_the_labyrinth_of_death.Classes.PlayerClasses.Abstract.AbstractNpc;

namespace Еscape_from_the_labyrinth_of_death.Classes.PlayerClasses.Abstract.AbstractNpc
{
    public class StandardNpcPlayer : NpcPlayer
    {
        public StandardNpcPlayer(byte health, byte attack, byte defence, byte intelligence,
            PictureBox pictureBoxPlayer, byte level, uint respawnInterval,
            PlayerClass playerClass, string name, Image smallImage, Image largeImage)
            : base(health, attack, defence, intelligence, pictureBoxPlayer, level, 
            respawnInterval, playerClass, false, name, smallImage, largeImage)
        {
            
        }
    }
}
