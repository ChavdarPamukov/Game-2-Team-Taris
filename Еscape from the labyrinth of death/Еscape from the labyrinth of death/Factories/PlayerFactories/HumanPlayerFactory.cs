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
    internal class HumanPlayerFactory : PlayerFactory
    {
        public static readonly IPlayerFactory HUMAN_PLAYER_FACTORY = new HumanPlayerFactory();

        private HumanPlayerFactory()
        {
            //nothing to do here
        }

        public override IPlayer Create(PictureBox pictureBoxPlayer, List<PictureBox> pictureBoxListWalls, 
            PlayerClass playerClass)
        {
            switch (playerClass)
            {
                case PlayerClass.Elf:
                    return this.CreateElf(pictureBoxPlayer, pictureBoxListWalls);
                case PlayerClass.Knight:
                    return this.CreateKnight(pictureBoxPlayer, pictureBoxListWalls);
                case PlayerClass.Mage:
                    return this.CreateMage(pictureBoxPlayer, pictureBoxListWalls);
                default:
                    throw new InvalidPlayerClassException("Could not create new Human player. Invalid class provided");
            }
        }

        private IPlayer CreateElf(PictureBox pictureBoxPlayer, List<PictureBox> pictureBoxListWalls)
        {
            return new Elf(pictureBoxPlayer, pictureBoxListWalls);
        }

        private IPlayer CreateKnight(PictureBox pictureBoxPlayer, List<PictureBox> pictureBoxListWalls)
        {
            return new Knight(pictureBoxPlayer, pictureBoxListWalls);
        }

        private IPlayer CreateMage(PictureBox pictureBoxPlayer, List<PictureBox> pictureBoxListWalls)
        {
            return new Mage(pictureBoxPlayer, pictureBoxListWalls);
        }
    }
}
