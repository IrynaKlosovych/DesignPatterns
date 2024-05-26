using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4.Mediator
{
    abstract class Base
    {
        public CommandCentre? Mediator { protected get; set; }
    }
}
