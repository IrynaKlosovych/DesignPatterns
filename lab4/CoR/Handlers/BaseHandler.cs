using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4.CoR.Handlers
{
    public abstract class BaseHandler: IHandler
    {
        private IHandler? next;
        public IHandler SetNext(IHandler next)
        {
            this.next = next;
            return next;
        }

        public virtual int? Handle(int request)
        {
            if (this.next != null)
            {
               return this.next.Handle(request);
            }
            else
            {
                Console.WriteLine("Handler is null");
                return null;
            }
        }
    }
}
