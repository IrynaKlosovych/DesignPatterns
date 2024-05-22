using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3.Proxy
{
    public interface ISmartTextReader
    {
        char[][]? ReadFile(string filepath);
    }
}
