using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses;
using Еscape_from_the_labyrinth_of_death.Classes.PlayerClasses.Abstract.AbstractNpc;

namespace Еscape_from_the_labyrinth_of_death.Classes.PlayerClasses.Concrete.ConcreteNpcPlayer.Standard
{
    public class StandardEvilElf : StandardNpcPlayer
    {
        private const byte _evilElfHealth = 45;
        private const byte _evilElfAttack = 30;
        private const byte _evilElfDefence = 35;
        private const byte _evilElfIntelligence = 30;
        private const PlayerClass _playerClass = PlayerClass.EvilElf;
        private const byte _level = 15;
        private const int _respawnTime = 100000;

        public StandardEvilElf(PictureBox pictureBoxPlayer, List<PictureBox> pictureBoxListWalls)
            : base(_evilElfHealth, _evilElfAttack, _evilElfDefence, _evilElfIntelligence, pictureBoxPlayer,
            _level, _respawnTime, _playerClass)
        {

        }
    }
}
