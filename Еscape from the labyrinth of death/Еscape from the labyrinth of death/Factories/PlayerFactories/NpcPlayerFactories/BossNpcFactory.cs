using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Еscape_from_the_labyrinth_of_death.Interfaces;
using Еscape_from_the_labyrinth_of_death.Exceptions;
using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses;
using Еscape_from_the_labyrinth_of_death.Classes.PlayerClasses.Concrete.ConcreteNpcPlayer.Bosses;

namespace Еscape_from_the_labyrinth_of_death.Factories.PlayerFactories.NpcPlayerFactories
{
    internal class BossNpcFactory : NpcPlayerFactory
    {
        public static readonly IPlayerFactory BOSS_NPC_FACTORY = new BossNpcFactory();

        private BossNpcFactory()
        {
            //nothing to do here
        }

        public override IPlayer Create(PictureBox pictureBoxPlayer, List<PictureBox> pictureBoxListWalls,
            List<INpcPlayer> enemiesList,
            PlayerClass playerClass)
        {
            switch (playerClass)
            {
                case PlayerClass.BossDragonfly:
                    return this.CreateDragonFly(pictureBoxPlayer, pictureBoxListWalls);
                case PlayerClass.BossEgg:
                    return this.CreateEgg(pictureBoxPlayer, pictureBoxListWalls);
                case PlayerClass.BossWarrior:
                    return this.CreateWarrior(pictureBoxPlayer, pictureBoxListWalls);
                default:
                    throw new InvalidPlayerClassException("Could not create new Boss Npc player." +
                        "Invalid class provided: " + playerClass);
            }
        }

        private IPlayer CreateDragonFly(PictureBox pictureBoxPlayer, List<PictureBox> pictureBoxListWalls)
        {
            return new BossNpcDragonfly(pictureBoxPlayer, pictureBoxListWalls);
        }

        private IPlayer CreateEgg(PictureBox pictureBoxPlayer, List<PictureBox> pictureBoxListWalls)
        {
            return new BossNpcEgg(pictureBoxPlayer, pictureBoxListWalls);
        }

        private IPlayer CreateWarrior(PictureBox pictureBoxPlayer, List<PictureBox> pictureBoxListWalls)
        {
            return new BossNpcWarrior(pictureBoxPlayer, pictureBoxListWalls);
        }
    }
}
