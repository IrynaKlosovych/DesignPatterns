using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4.CoR.Handlers
{
    public class SecondHandler: BaseHandler
    {
        public override int? Handle(int request)
        {
            if (request == 2)
            {
                Console.WriteLine("It's Handler 2");
                return 2;
            }
            else
            {
                Console.WriteLine("It was Handler 2, but it was wrong");
                return base.Handle(request);
            }
        }
    }
}
