using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses;
using Еscape_from_the_labyrinth_of_death.Interfaces;
using Еscape_from_the_labyrinth_of_death.Factories.PlayerFactories;

namespace Еscape_from_the_labyrinth_of_death.Factories
{
    public class PlayerFactory : IPlayerFactory
    {
        public static readonly PlayerFactory PLAYER_FACTORY = new PlayerFactory();
        private readonly IPlayerFactory _humanPlayerFactory;
        private readonly IPlayerFactory _npcPlayerFactory;

        protected PlayerFactory()
        {
           this._humanPlayerFactory = HumanPlayerFactory.HUMAN_PLAYER_FACTORY;
           this._npcPlayerFactory = NpcPlayerFactory.NPC_PLAYER_FACTORY;
        }

        public virtual IPlayer Create(PictureBox pictureBoxPlayer, List<PictureBox> pictureBoxListWalls, PlayerClass playerClass)
        {
            if (NewPlayerIsHuman(playerClass))
            {
                return CreateHumanPlayer(pictureBoxPlayer, pictureBoxListWalls, playerClass);
            }
            else
            {
                return CreateNpcPlayer(pictureBoxPlayer, pictureBoxListWalls, playerClass);
            }
        }

        private bool NewPlayerIsHuman(PlayerClass playerClass)
        {
            return playerClass == PlayerClass.Elf ||
                playerClass == PlayerClass.Knight ||
                playerClass == PlayerClass.Mage;
        }

        private IPlayer CreateHumanPlayer(PictureBox pictureBoxPlayer, List<PictureBox> pictureBoxListWalls, 
            PlayerClass playerClass) 
        {
            return this._humanPlayerFactory.Create(pictureBoxPlayer, pictureBoxListWalls, playerClass);
        }

        private IPlayer CreateNpcPlayer(PictureBox pictureBoxPlayer, List<PictureBox> pictureBoxListWalls,
            PlayerClass playerClass)
        {
            return this._npcPlayerFactory.Create(pictureBoxPlayer, pictureBoxListWalls, playerClass);
        }
    }
}
