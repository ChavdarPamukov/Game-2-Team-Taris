using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Еscape_from_the_labyrinth_of_death.Interfaces;
using Еscape_from_the_labyrinth_of_death.Exceptions;
using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses;
using Еscape_from_the_labyrinth_of_death.Classes.PlayerClasses.Concrete.ConcreteHumanPlayer;

namespace Еscape_from_the_labyrinth_of_death.Factories.PlayerFactories
{
    internal class NpcPlayerFactory : PlayerFactory
    {
        public static readonly IPlayerFactory NPC_PLAYER_FACTORY = new NpcPlayerFactory();

        private NpcPlayerFactory()
        {
            //nothing to do here
        }

        public override IPlayer Create(PictureBox pictureBoxPlayer, List<PictureBox> pictureBoxListWalls, 
            PlayerClass playerClass)
        {
            //Creating npcs goes here
            throw new NotImplementedException();
        }
    }
}
