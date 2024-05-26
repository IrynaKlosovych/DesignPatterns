using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4.Strategy
{
    public class FromNetwork: IStrategy
    {
        public void Execute(string href)
        {
            Console.WriteLine($"Download from network: {href}");
        }
    }
}
