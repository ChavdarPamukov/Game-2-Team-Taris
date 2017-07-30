using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Еscape_from_the_labyrinth_of_death.Interfaces;

namespace Еscape_from_the_labyrinth_of_death.Engine
{
    public class GameEngine
    {
        public readonly List<Form> _levels = new List<Form>();
        private readonly IHumanPlayer _player;
        private readonly List<INpcPlayer> _enemiesList;
    }
}
