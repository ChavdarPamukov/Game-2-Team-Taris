using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Еscape_from_the_labyrinth_of_death.Interfaces
{
    interface IPlayer
    {
        byte Health { set; get; }
        byte Attack { set; get; }
        byte Defence { set; get; }
        byte Intelligence { set; get; }
        PictureBox PictureBoxPlayer { set; get; }
        List<PictureBox> PictureBoxListWalls { set; get; }
        List<IItem> GetInventory();
        IItem BodyArmor { set; get; }
        IItem Helmet { set; get; }
        IItem Shield { set; get; }
        IItem Weapon { set; get; }
        bool IsDead { set; get; }
    }
}
