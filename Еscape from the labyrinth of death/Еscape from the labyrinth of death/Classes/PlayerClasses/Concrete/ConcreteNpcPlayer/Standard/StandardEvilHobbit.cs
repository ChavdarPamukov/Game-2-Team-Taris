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
    public class StandardEvilHobbit : StandardNpcPlayer
    {
        private const byte _evilHobbitHealth = 25;
        private const byte _evilHobbitAttack = 10;
        private const byte _evilHobbitDefence = 15;
        private const byte _evilHobbitIntelligence = 10;
        private const PlayerClass _playerClass = PlayerClass.EvilHobbit;
        private const byte _level = 5;
        private const int _respawnTime = 15;
        private const string _name = "Hobbit";
        private static string _smallImagePath = Directory.GetCurrentDirectory() + "../../../Resources/enemy_1_35.png";
        private static string _largeImagePath = Directory.GetCurrentDirectory() + "../../../Resources/enemy_1_248.png";
        private static Image _smallImage = Image.FromFile(_smallImagePath);
        private static Image _largeImage = Image.FromFile(_largeImagePath);

        public StandardEvilHobbit(PictureBox pictureBoxPlayer, List<PictureBox> pictureBoxListWalls)
            : base(_evilHobbitHealth, _evilHobbitAttack, _evilHobbitDefence, _evilHobbitIntelligence, pictureBoxPlayer,
            _level, _respawnTime, _playerClass, _name, _smallImage, _largeImage)
        {

        }
    }
}
