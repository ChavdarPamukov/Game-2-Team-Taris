using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses;

namespace Еscape_from_the_labyrinth_of_death.Interfaces
{
    public interface IPlayer
    {
        byte Health { set; get; }
        byte Attack { set; get; }
        byte Defence { set; get; }
        byte Intelligence { set; get; }
        PictureBox PictureBoxPlayer { set; get; }
        List<IItem> Inventory { set; get; }
        IItem BodyArmor { set; get; }
        IItem Helmet { set; get; }
        IItem Shield { set; get; }
        IItem Weapon { set; get; }
        bool IsDead { set; get; }
        bool IsHuman { get; }
        PlayerClass PlayerClass { get; }
        byte Level { set; get; }
    }
}
