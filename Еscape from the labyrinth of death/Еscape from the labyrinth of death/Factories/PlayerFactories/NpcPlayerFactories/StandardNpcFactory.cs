using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Еscape_from_the_labyrinth_of_death.Interfaces;
using Еscape_from_the_labyrinth_of_death.Exceptions;
using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses;
using Еscape_from_the_labyrinth_of_death.Classes.PlayerClasses.Concrete.ConcreteNpcPlayer.Standard;

namespace Еscape_from_the_labyrinth_of_death.Factories.PlayerFactories.NpcPlayerFactories
{
    internal class StandardNpcFactory : NpcPlayerFactory
    {
        public static readonly IPlayerFactory STANDARD_NPC_FACTORY = new StandardNpcFactory();

        private StandardNpcFactory()
        {
            //nothing to do here
        }

        public override IPlayer Create(PictureBox pictureBoxPlayer, List<PictureBox> pictureBoxListWalls,
            List<INpcPlayer> enemiesList,
            PlayerClass playerClass, string name)
        {
            switch (playerClass)
            {
                case PlayerClass.EvilDragon:
                    return this.CreateEvilDragon(pictureBoxPlayer, pictureBoxListWalls);
                case PlayerClass.EvilElf:
                    return this.CreateEvilElf(pictureBoxPlayer, pictureBoxListWalls);
                case PlayerClass.EvilHobbit:
                    return this.CreateEvilHobbit(pictureBoxPlayer, pictureBoxListWalls);
                case PlayerClass.EvilKnight:
                    return this.CreateEvilKnight(pictureBoxPlayer, pictureBoxListWalls);
                case PlayerClass.EvilMask:
                    return this.CreateEvilMask(pictureBoxPlayer, pictureBoxListWalls);
                default:
                    throw new InvalidPlayerClassException("Could not create new Standard Npc player." +
                        "Invalid class provided: " + playerClass);
            }
        }

        private IPlayer CreateEvilDragon(PictureBox pictureBoxPlayer, List<PictureBox> pictureBoxListWalls)
        {
            return new StandardEvilDragon(pictureBoxPlayer, pictureBoxListWalls);
        }

        private IPlayer CreateEvilElf(PictureBox pictureBoxPlayer, List<PictureBox> pictureBoxListWalls)
        {
            return new StandardEvilElf(pictureBoxPlayer, pictureBoxListWalls);
        }

        private IPlayer CreateEvilHobbit(PictureBox pictureBoxPlayer, List<PictureBox> pictureBoxListWalls)
        {
            return new StandardEvilHobbit(pictureBoxPlayer, pictureBoxListWalls);
        }

        private IPlayer CreateEvilKnight(PictureBox pictureBoxPlayer, List<PictureBox> pictureBoxListWalls)
        {
            return new StandardEvilKnight(pictureBoxPlayer, pictureBoxListWalls);
        }

        private IPlayer CreateEvilMask(PictureBox pictureBoxPlayer, List<PictureBox> pictureBoxListWalls)
        {
            return new StandardEvilMask(pictureBoxPlayer, pictureBoxListWalls);
        }
    }
}
