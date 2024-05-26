using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4.Observer.Events
{
    public class Click : IEventListener
    {
        public void Update()
        {
            Console.WriteLine("It was click");
        }
    }
}
