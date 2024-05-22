using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3.Decorator.Heroes
{
    public class Palladin: Hero
    {
        public Palladin() : base()
        {
            this.Power = 100;
            this.Energy = 100;
        }
        public override int GetPower()
        {
            Console.WriteLine($"Palladin has {Power} power");
            return this.Power;
        }
        public override int GetEnergy()
        {
            Console.WriteLine($"Palladin has {Energy} energy");
            return this.Energy;
        }
    }
}
