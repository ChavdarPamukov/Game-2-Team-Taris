using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Еscape_from_the_labyrinth_of_death.Interfaces;
using Еscape_from_the_labyrinth_of_death.Exceptions;
using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses;
using Еscape_from_the_labyrinth_of_death.Factories.PlayerFactories.NpcPlayerFactories;

namespace Еscape_from_the_labyrinth_of_death.Factories.PlayerFactories
{
    internal class NpcPlayerFactory : PlayerFactory
    {
        public static readonly IPlayerFactory NPC_PLAYER_FACTORY = new NpcPlayerFactory();
        private readonly IPlayerFactory _standardNpcFactory;
        private readonly IPlayerFactory _bossNpcFactory;
        private readonly PlayerClass[] _bossNpcClasses;

        protected NpcPlayerFactory()
        {
            this._standardNpcFactory = StandardNpcFactory.STANDARD_NPC_FACTORY;
            this._bossNpcFactory = BossNpcFactory.BOSS_NPC_FACTORY;

            this._bossNpcClasses = new PlayerClass[] 
            {
                PlayerClass.BossDragonfly,
                PlayerClass.BossEgg,
                PlayerClass.BossWarrior,
            };
        }

        public override IPlayer Create(PictureBox pictureBoxPlayer, List<PictureBox> pictureBoxListWalls,
            List<INpcPlayer> enemiesList,
            PlayerClass playerClass)
        {
            if (this._bossNpcClasses.Contains(playerClass))
            {
                return this.CreateBossNpc(pictureBoxPlayer, pictureBoxListWalls,
                    enemiesList, playerClass);
            }
            else
            {
                return this.CreateStandardNpc(pictureBoxPlayer, pictureBoxListWalls,
                    enemiesList, playerClass);
            }
        }

        private IPlayer CreateBossNpc(PictureBox pictureBoxPlayer, List<PictureBox> pictureBoxListWalls,
            List<INpcPlayer> enemiesList,
            PlayerClass playerClass)
        {
            return this._bossNpcFactory.Create(pictureBoxPlayer, pictureBoxListWalls,
                    enemiesList, playerClass);
        }

        private IPlayer CreateStandardNpc(PictureBox pictureBoxPlayer, List<PictureBox> pictureBoxListWalls,
            List<INpcPlayer> enemiesList,
            PlayerClass playerClass)
        {
            return this._standardNpcFactory.Create(pictureBoxPlayer, pictureBoxListWalls,
                    enemiesList, playerClass);
        }
    }
}
