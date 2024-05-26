using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lab4.Memento
{
    public interface ITextEditor
    {
        public IMemento Save();
    }
}
