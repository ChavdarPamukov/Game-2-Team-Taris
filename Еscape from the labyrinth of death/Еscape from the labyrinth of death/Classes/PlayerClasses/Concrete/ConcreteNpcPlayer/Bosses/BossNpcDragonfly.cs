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
    public class BossNpcDragonfly : BossNpcPlayer
    {
        private const byte _dragonflyHealth = 150;
        private const byte _dragonflyAttack = 150;
        private const byte _dragonflyDefence = 150;
        private const byte _dragonflyIntelligence = 150;
        private const PlayerClass _playerClass = PlayerClass.BossDragonfly;
        private const byte _level = 30;

        public BossNpcDragonfly(PictureBox pictureBoxPlayer, List<PictureBox> pictureBoxListWalls)
            : base(_dragonflyHealth, _dragonflyAttack, _dragonflyDefence, _dragonflyIntelligence, pictureBoxPlayer,
            _level, 0, _playerClass)
        {

        }
    }
}
