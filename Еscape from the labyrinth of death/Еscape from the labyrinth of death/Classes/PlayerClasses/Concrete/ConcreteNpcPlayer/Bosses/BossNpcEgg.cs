using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses;
using Еscape_from_the_labyrinth_of_death.Classes.PlayerClasses.Abstract.AbstractNpc;

namespace Еscape_from_the_labyrinth_of_death.Classes.PlayerClasses.Concrete.ConcreteNpcPlayer.Bosses
{
    public class BossNpcEgg : BossNpcPlayer
    {
        private const byte _eggHealth = 150;
        private const byte _eggAttack = 150;
        private const byte _eggDefence = 150;
        private const byte _eggIntelligence = 150;
        private const PlayerClass _playerClass = PlayerClass.BossEgg;
        private const byte _level = 30;

        public BossNpcEgg(PictureBox pictureBoxPlayer, List<PictureBox> pictureBoxListWalls)
            : base(_eggHealth, _eggAttack, _eggDefence, _eggIntelligence, pictureBoxPlayer,
            _level, 0, _playerClass)
        {

        }
    }
}
