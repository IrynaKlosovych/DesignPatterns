using lab3.Decorator.Heroes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3.Decorator.Inventory
{
    public abstract class Inventory: Hero
    {
        protected Hero _hero;
        public Inventory(Hero hero) { 
            this._hero = hero;
        }
    }
}
