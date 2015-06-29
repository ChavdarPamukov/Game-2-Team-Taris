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
    public class StandardEvilHobbit : StandardNpcPlayer
    {
        private const byte _evilHobbitHealth = 25;
        private const byte _evilHobbitAttack = 10;
        private const byte _evilHobbitDefence = 15;
        private const byte _evilHobbitIntelligence = 10;
        private const PlayerClass _playerClass = PlayerClass.EvilHobbit;
        private const byte _level = 5;
        private const int _respawnTime = 1000;

        public StandardEvilHobbit(PictureBox pictureBoxPlayer, List<PictureBox> pictureBoxListWalls)
            : base(_evilHobbitHealth, _evilHobbitAttack, _evilHobbitDefence, _evilHobbitIntelligence, pictureBoxPlayer,
            _level, _respawnTime, _playerClass)
        {

        }
    }
}
