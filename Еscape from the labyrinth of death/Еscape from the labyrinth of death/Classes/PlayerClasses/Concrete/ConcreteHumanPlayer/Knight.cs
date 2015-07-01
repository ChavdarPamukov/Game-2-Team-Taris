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
    public class Knight : HumanPlayer
    {
        private const byte _knightHealth = 100;
        private const byte _knightAttack = 75;
        private const byte _knightDefence = 80;
        private const byte _knightIntelligence = 20;
        private const PlayerClass _playerClass = PlayerClass.Knight;
        private static string _smallImagePath = Directory.GetCurrentDirectory() + "../../../Resources/warrior_35.png";
        private static string _largeImagePath = Directory.GetCurrentDirectory() + "../../../Resources/warrior_248.png";
        private static Image _smallImage = Image.FromFile(_smallImagePath);
        private static Image _largeImage = Image.FromFile(_largeImagePath);

        public Knight(PictureBox pictureBoxPlayer, List<PictureBox> pictureBoxListWalls,
            List<INpcPlayer> enemiesList, string name)
            : base(_knightHealth, _knightAttack, _knightDefence, _knightIntelligence,
            pictureBoxPlayer, _playerClass, pictureBoxListWalls, enemiesList, name,
            _smallImage, _largeImage)
        {

        }
    }
}
