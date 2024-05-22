using lab3.Decorator.Heroes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3.Decorator.Inventory
{
    public class Clothes : Inventory
    {
        private int numPower = 10;
        private int numEnergy = 20;
        public Clothes(Hero hero): base(hero) {
            _hero.SetPower(_hero.Power + numPower);
            _hero.SetEnergy(_hero.Energy + numEnergy);
        }
        public override int GetPower()
        {
            Console.WriteLine($"Clothes adds {numPower} power");
            Console.WriteLine($"Now Power is {_hero.Power}");
            return _hero.Power;
        }

        public override int GetEnergy()
        {
            Console.WriteLine($"Clothes adds {numEnergy} energy");
            Console.WriteLine($"Now Energy is {_hero.Energy}");
            return _hero.Energy;
        }
    }
}
