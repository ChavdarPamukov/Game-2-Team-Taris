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
    public class StandardEvilKnight : StandardNpcPlayer
    {
        private const byte _evilKnightHealth = 55;
        private const byte _evilKnightAttack = 40;
        private const byte _evilKnightDefence = 45;
        private const byte _evilKnightIntelligence = 40;
        private const PlayerClass _playerClass = PlayerClass.EvilKnight;
        private const byte _level = 20;
        private const int _respawnTime = 1000000;

        public StandardEvilKnight(PictureBox pictureBoxPlayer, List<PictureBox> pictureBoxListWalls)
            : base(_evilKnightHealth, _evilKnightAttack, _evilKnightDefence, _evilKnightIntelligence, pictureBoxPlayer,
            _level, _respawnTime, _playerClass)
        {

        }
    }
}
