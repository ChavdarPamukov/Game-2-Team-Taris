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

namespace Еscape_from_the_labyrinth_of_death.Classes.PlayerClasses.Concrete.ConcreteNpcPlayer.Bosses
{
    public class BossNpcWarrior : BossNpcPlayer
    {
        private const byte _warriorHealth = 150;
        private const byte _warriorAttack = 150;
        private const byte _warriorDefence = 150;
        private const byte _warriorIntelligence = 150;
        private const PlayerClass _playerClass = PlayerClass.BossWarrior;
        private const byte _level = 30;
        private const string _name = "Warrior";
        private static string _smallImagePath = Directory.GetCurrentDirectory() + "../../../Resources/boss_1_35.png";
        private static string _largeImagePath = Directory.GetCurrentDirectory() + "../../../Resources/boss_1_248.png";
        private static Image _smallImage = Image.FromFile(_smallImagePath);
        private static Image _largeImage = Image.FromFile(_largeImagePath);


        public BossNpcWarrior(PictureBox pictureBoxPlayer, List<PictureBox> pictureBoxListWalls)
            : base(_warriorHealth, _warriorAttack, _warriorDefence, _warriorIntelligence, pictureBoxPlayer,
            _level, 0, _playerClass, _name, _smallImage, _largeImage)
        {

        }
    }
}
