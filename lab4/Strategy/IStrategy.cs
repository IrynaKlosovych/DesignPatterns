using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4.Strategy
{
    public interface IStrategy
    {
        public void Execute(string href);
    }
}
