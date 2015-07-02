using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses;
using Еscape_from_the_labyrinth_of_death.Classes.PlayerClasses.Abstract.AbstractNpc;

namespace Еscape_from_the_labyrinth_of_death.Classes.PlayerClasses.Concrete.ConcreteNpcPlayer.Standard
{
    public class StandardEvilKnight : StandardNpcPlayer
    {
        private const byte _evilKnightHealth = 55;
        private const byte _evilKnightAttack = 50;
        private const byte _evilKnightDefence = 45;
        private const byte _evilKnightIntelligence = 40;
        private const PlayerClass _playerClass = PlayerClass.EvilKnight;
        private const byte _level = 20;
        private const int _respawnTime = 90;
        private const string _name = "Knight";
        private static string _smallImagePath = Directory.GetCurrentDirectory() + "../../../Resources/enemy_2_35.png";
        private static string _largeImagePath = Directory.GetCurrentDirectory() + "../../../Resources/enemy_2_248.png";
        private static Image _smallImage = Image.FromFile(_smallImagePath);
        private static Image _largeImage = Image.FromFile(_largeImagePath);

        public StandardEvilKnight(PictureBox pictureBoxPlayer, List<PictureBox> pictureBoxListWalls)
            : base(_evilKnightHealth, _evilKnightAttack, _evilKnightDefence, _evilKnightIntelligence, pictureBoxPlayer,
            _level, _respawnTime, _playerClass, _name, _smallImage, _largeImage)
        {

        }
    }
}
