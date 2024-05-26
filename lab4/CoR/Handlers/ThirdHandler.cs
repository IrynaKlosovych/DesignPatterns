using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4.CoR.Handlers
{
    public class ThirdHandler : BaseHandler
    {
        public override int? Handle(int request)
        {
            if (request == 3)
            {
                Console.WriteLine("It's Handler 3");
                return 3;
            }
            else
            {
                Console.WriteLine("It was Handler 3, but it was wrong");
                return base.Handle(request);
            }
        }
    }
}
