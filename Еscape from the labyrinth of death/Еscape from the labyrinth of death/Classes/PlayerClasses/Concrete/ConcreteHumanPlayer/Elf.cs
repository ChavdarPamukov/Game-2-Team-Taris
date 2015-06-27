using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses;
using Еscape_from_the_labyrinth_of_death.Classes.PlayerClasses.Abstract.AbstractHuman;

namespace Еscape_from_the_labyrinth_of_death.Classes.PlayerClasses.Concrete.ConcreteHumanPlayer
{
    public class Elf : HumanPlayer
    {
        private const byte _elfHealth = 80;
        private const byte _elfAttack = 65;
        private const byte _elfDefence = 50;
        private const byte _elfIntelligence = 60;
        private const PlayerClass _playerClass = PlayerClass.Elf;

        public Elf(PictureBox pictureBoxPlayer, List<PictureBox> pictureBoxListWalls)
            : base(_elfHealth, _elfAttack, _elfDefence, _elfIntelligence, pictureBoxPlayer, _playerClass, pictureBoxListWalls)
        {

        }
    }
}
