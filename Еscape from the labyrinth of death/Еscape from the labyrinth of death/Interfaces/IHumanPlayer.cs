using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Еscape_from_the_labyrinth_of_death.Interfaces
{
    enum PlayerClass
    {
        Mage,
        Wizard,
        Warrior
    }

    interface IHumanPlayer : IPlayer
    {
        //byte Level { set; get; }
        int Experience { set; get; }
        void MoveUp();
        void MoveRight();
        void MoveDown();
        void MoveLeft();
        IItem Potion { set; get; }
        void AddToInventory(IItem item);
        PlayerClass PlayerClass { get; }
        List<PictureBox> PictureBoxListWalls { set; get; }
    }
}
