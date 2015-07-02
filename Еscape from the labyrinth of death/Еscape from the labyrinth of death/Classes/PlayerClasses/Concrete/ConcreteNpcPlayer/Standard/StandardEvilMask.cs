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
    public class StandardEvilMask : StandardNpcPlayer
    {
        private const byte _evilMaskHealth = 35;
        private const byte _evilMaskAttack = 30;
        private const byte _evilMaskDefence = 25;
        private const byte _evilMaskIntelligence = 30;
        private const PlayerClass _playerClass = PlayerClass.EvilMask;
        private const byte _level = 10;
        private const int _respawnTime = 30;
        private const string _name = "Mask";
        private static string _smallImagePath = Directory.GetCurrentDirectory() + "../../../Resources/enemy_4_35.png";
        private static string _largeImagePath = Directory.GetCurrentDirectory() + "../../../Resources/enemy_4_248.png";
        private static Image _smallImage = Image.FromFile(_smallImagePath);
        private static Image _largeImage = Image.FromFile(_largeImagePath);

        public StandardEvilMask(PictureBox pictureBoxPlayer, List<PictureBox> pictureBoxListWalls)
            : base(_evilMaskHealth, _evilMaskAttack, _evilMaskDefence, _evilMaskIntelligence, pictureBoxPlayer,
            _level, _respawnTime, _playerClass, _name,_smallImage, _largeImage)
        {

        }
    }
}
