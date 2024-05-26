using lab4.CoR.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4.CoR
{
    public static class ClientCoR
    {
        public static IHandler GetInterceptors()
        {
            var first = new FirstHandler();
            var second = new SecondHandler();
            var third = new ThirdHandler();
            var fourth = new FourthHandler();

            first
              .SetNext(second)
              .SetNext(third)
              .SetNext(fourth);

            return first;
        }
    }
}
