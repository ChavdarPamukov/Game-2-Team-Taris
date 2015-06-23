using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Еscape_from_the_labyrinth_of_death.Interfaces
{
    interface IHumanPlayer : IPlayer
    {
        byte Level { set; get; }
        ushort Experience { set; get; }
        void MoveUp();
        void MoveRight();
        void MoveDown();
        void MoveLeft();
        IItem Potion { set; get; }
        void AddToInventory(IItem item);
    }
}
