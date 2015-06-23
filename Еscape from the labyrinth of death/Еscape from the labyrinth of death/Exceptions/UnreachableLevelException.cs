using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Еscape_from_the_labyrinth_of_death.Exceptions
{
    class UnreachableLevelException : ArgumentOutOfRangeException
    {
        public UnreachableLevelException(String message)
            : base(message)
        {
            //Nothing to do here
        }
    }
}
