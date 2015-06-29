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
    public class StandardEvilDragon : StandardNpcPlayer
    {
        private const byte _evilDragonHealth = 65;
        private const byte _evilDragonAttack = 50;
        private const byte _evilDragonDefence = 55;
        private const byte _evilDragonIntelligence = 50;
        private const PlayerClass _playerClass = PlayerClass.EvilDragon;
        private const byte _level = 25;
        private const int _respawnTime = 10000000;

        public StandardEvilDragon(PictureBox pictureBoxPlayer, List<PictureBox> pictureBoxListWalls)
            : base(_evilDragonHealth, _evilDragonAttack, _evilDragonDefence, _evilDragonIntelligence, pictureBoxPlayer,
            _level, _respawnTime, _playerClass)
        {

        }
    }
}
