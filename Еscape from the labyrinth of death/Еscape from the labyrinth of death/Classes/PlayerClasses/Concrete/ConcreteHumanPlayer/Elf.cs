using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using Еscape_from_the_labyrinth_of_death.Interfaces;
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
        private static string _smallImagePath = Directory.GetCurrentDirectory() + "../../../Resources/elf_35.png";
        private static string _largeImagePath = Directory.GetCurrentDirectory() + "../../../Resources/elf_248.png";
        private static Image _smallImage = Image.FromFile(_smallImagePath);
        private static Image _largeImage = Image.FromFile(_largeImagePath);

        public Elf(PictureBox pictureBoxPlayer, List<PictureBox> pictureBoxListWalls,
            List<INpcPlayer> enemiesList, string name)
            : base(_elfHealth, _elfAttack, _elfDefence, _elfIntelligence,
            pictureBoxPlayer, _playerClass, pictureBoxListWalls, enemiesList, name,
            _smallImage, _largeImage)
        {

        }
    }
}
