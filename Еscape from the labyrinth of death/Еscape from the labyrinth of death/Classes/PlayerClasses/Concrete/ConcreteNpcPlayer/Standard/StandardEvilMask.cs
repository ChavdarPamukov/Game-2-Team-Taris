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
    public class StandardEvilMask : StandardNpcPlayer
    {
        private const byte _evilMaskHealth = 35;
        private const byte _evilMaskAttack = 20;
        private const byte _evilMaskDefence = 25;
        private const byte _evilMaskIntelligence = 20;
        private const PlayerClass _playerClass = PlayerClass.EvilMask;
        private const byte _level = 10;
        private const int _respawnTime = 10000;

        public StandardEvilMask(PictureBox pictureBoxPlayer, List<PictureBox> pictureBoxListWalls)
            : base(_evilMaskHealth, _evilMaskAttack, _evilMaskDefence, _evilMaskIntelligence, pictureBoxPlayer,
            _level, _respawnTime, _playerClass)
        {

        }
    }
}
