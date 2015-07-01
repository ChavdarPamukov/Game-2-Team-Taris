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
        private readonly PlayerClass[] _humanPlayerClasses;

        protected PlayerFactory()
        {
           this._humanPlayerFactory = HumanPlayerFactory.HUMAN_PLAYER_FACTORY;
           this._npcPlayerFactory = NpcPlayerFactory.NPC_PLAYER_FACTORY;
           this._humanPlayerClasses = new PlayerClass[] 
           {
               PlayerClass.Elf,
               PlayerClass.Mage,
               PlayerClass.Knight,
           };
        }

        public virtual IPlayer Create(PictureBox pictureBoxPlayer, List<PictureBox> pictureBoxListWalls, 
            List<INpcPlayer> enemiesList, PlayerClass playerClass, string name)
        {
            if (this._humanPlayerClasses.Contains(playerClass))
            {
                return CreateHumanPlayer(pictureBoxPlayer, pictureBoxListWalls, 
                    enemiesList, playerClass, name);
            }
            else
            {
                return CreateNpcPlayer(pictureBoxPlayer, pictureBoxListWalls, 
                    enemiesList, playerClass, name);
            }
        }

        private IPlayer CreateHumanPlayer(PictureBox pictureBoxPlayer, List<PictureBox> pictureBoxListWalls,
            List<INpcPlayer> enemiesList,
            PlayerClass playerClass, string name) 
        {
            return this._humanPlayerFactory.Create(pictureBoxPlayer, pictureBoxListWalls, 
                enemiesList, playerClass, name);
        }

        private IPlayer CreateNpcPlayer(PictureBox pictureBoxPlayer, List<PictureBox> pictureBoxListWalls,
            List<INpcPlayer> enemiesList,
            PlayerClass playerClass, string name)
        {
            return this._npcPlayerFactory.Create(pictureBoxPlayer, pictureBoxListWalls, 
                enemiesList, playerClass, name);
        }
    }
}
