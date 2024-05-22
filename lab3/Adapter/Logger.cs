using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3.Adapter
{
    public class Logger
    {
        public virtual void Log()
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }
        public virtual void Error() {
            Console.ForegroundColor = ConsoleColor.Red;
        }
        public virtual void Warn()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
        public virtual void Reset()
        {
            Console.ResetColor();
        }
    }
}
