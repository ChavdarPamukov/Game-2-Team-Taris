using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses;

namespace Еscape_from_the_labyrinth_of_death.Interfaces
{
    public interface INpcPlayer : IPlayer
    {
        uint RespawnInterval { set; get; }
        void Respawn();
        bool IsBoss { get; }
    }
}
