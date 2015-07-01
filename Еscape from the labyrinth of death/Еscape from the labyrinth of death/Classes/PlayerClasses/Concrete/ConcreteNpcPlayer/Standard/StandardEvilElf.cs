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
    public class StandardEvilElf : StandardNpcPlayer
    {
        private const byte _evilElfHealth = 45;
        private const byte _evilElfAttack = 30;
        private const byte _evilElfDefence = 35;
        private const byte _evilElfIntelligence = 30;
        private const PlayerClass _playerClass = PlayerClass.EvilElf;
        private const byte _level = 15;
        private const int _respawnTime = 60;
        private const string _name = "Elf";
        private static string _smallImagePath = Directory.GetCurrentDirectory() + "../../../Resources/enemy_3_35.png";
        private static string _largeImagePath = Directory.GetCurrentDirectory() + "../../../Resources/enemy_3_248.png";
        private static Image _smallImage = Image.FromFile(_smallImagePath);
        private static Image _largeImage = Image.FromFile(_largeImagePath);

        public StandardEvilElf(PictureBox pictureBoxPlayer, List<PictureBox> pictureBoxListWalls)
            : base(_evilElfHealth, _evilElfAttack, _evilElfDefence, _evilElfIntelligence, pictureBoxPlayer,
            _level, _respawnTime, _playerClass, _name, _smallImage, _largeImage)
        {
            
        }
    }
}
