using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4.CoR.Handlers
{
    public class FirstHandler: BaseHandler
    {
        public override int? Handle(int request)
        {
            if(request == 1)
            {
                Console.WriteLine("It's Handler 1");
                return 1;
            }
            else
            {
                Console.WriteLine("It was Handler 1, but it was wrong");
                return base.Handle(request);
            }
        }
    }
}
