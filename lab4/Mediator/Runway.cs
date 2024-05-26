using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4.Mediator
{
    class Runway: Base
    {
        public readonly Guid Id = Guid.NewGuid();
        public bool IsBusyWithAircraft { get; set; }
        public Runway(bool isBusyWithAircraft)
        {
            IsBusyWithAircraft = isBusyWithAircraft;
        }

        public void HighLightRed()
        {
            Console.WriteLine($"Runway {this.Id} is busy!");
        }

        public void HighLightGreen()
        {
            Console.WriteLine($"Runway {this.Id} is free!");
        }
    }
}
