using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3.Decorator.Heroes
{
    public class Warrior: Hero
    {
        public Warrior() : base()
        {
            this.Power = 150;
            this.Energy = 150;
        }
        public override int GetPower()
        {
            Console.WriteLine($"Warrior has {Power} power");
            return this.Power;
        }
        public override int GetEnergy()
        {
            Console.WriteLine($"Warrior has {Energy} energy");
            return this.Energy;
        }
    }
}
