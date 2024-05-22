using lab3.Decorator.Heroes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3.Decorator.Inventory
{
    public class Artefact : Inventory
    {
        private int num = 5;
        public Artefact(Hero hero) : base(hero) {
            _hero.SetPower(_hero.Power+num);
            _hero.SetEnergy(_hero.Energy+num);
        }

        public override int GetPower()
        {
            Console.WriteLine($"Artefact adds {num} power");
            Console.WriteLine($"Now Power is {_hero.Power}");
            return _hero.Power;
        }

        public override int GetEnergy()
        {
            Console.WriteLine($"Artefact adds {num} energy");
            Console.WriteLine($"Now Energy is {_hero.Energy}");
            return _hero.Energy;
        }
    }
}
