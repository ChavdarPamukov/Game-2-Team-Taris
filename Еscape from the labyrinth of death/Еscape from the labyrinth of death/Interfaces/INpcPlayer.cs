using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Еscape_from_the_labyrinth_of_death.Interfaces
{
    enum NpcType
    {
        //MUST DEFINE LATER
    }

    interface INpcPlayer : IPlayer
    {
        NpcType NpcType { set; get; }
        uint RespawnInterval { set; get; }
        void Respawn();
    }
}
