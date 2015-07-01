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
    public class Mage : HumanPlayer
    {
        private const byte _mageHealth = 60;
        private const byte _mageAttack = 70;
        private const byte _mageDefence = 35;
        private const byte _mageIntelligence = 80;
        private const PlayerClass _playerClass = PlayerClass.Mage;
        private static string _smallImagePath = Directory.GetCurrentDirectory() + "../../../Resources/wizard_35.png";
        private static string _largeImagePath = Directory.GetCurrentDirectory() + "../../../Resources/wizard_248.png";
        private static Image _smallImage = Image.FromFile(_smallImagePath);
        private static Image _largeImage = Image.FromFile(_largeImagePath);

        public Mage(PictureBox pictureBoxPlayer, List<PictureBox> pictureBoxListWalls,
            List<INpcPlayer> enemiesList, string name)
            : base(_mageHealth, _mageAttack, _mageDefence, _mageIntelligence,
            pictureBoxPlayer, _playerClass, pictureBoxListWalls, enemiesList, name,
            _smallImage, _largeImage)
        {

        }
    }
}
