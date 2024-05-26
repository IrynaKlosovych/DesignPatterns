using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4.CoR.Handlers
{
    public class FourthHandler: BaseHandler
    {
        public override int? Handle(int request)
        {
            if (request == 4)
            {
                Console.WriteLine("It's Handler 4");
                return 4;
            }
            else
            {
                Console.WriteLine("It was Handler 4, but it was wrong");
                return base.Handle(request);
            }
        }
    }
}
