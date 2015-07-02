﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Еscape_from_the_labyrinth_of_death.Exceptions
{
    public class InvalidPlayerTypeException : ArgumentOutOfRangeException
    {
        public InvalidPlayerTypeException(string message)
            : base(message)
        {
            //nothing to do here
        }
    }
}
