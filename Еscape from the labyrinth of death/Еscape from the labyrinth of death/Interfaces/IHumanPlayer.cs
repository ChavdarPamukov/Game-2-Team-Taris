using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses;

namespace Еscape_from_the_labyrinth_of_death.Interfaces
{
    public interface IHumanPlayer : IPlayer
    {
        int Experience { set; get; }
        void MoveUp();
        void MoveRight();
        void MoveDown();
        void MoveLeft();
        IItem Potion { set; get; }
        void AddToInventory(IItem item);
        List<PictureBox> PictureBoxListWalls { set; get; }
    }
}
