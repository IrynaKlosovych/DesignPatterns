using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4.Memento
{
    public interface IMemento
    {
        public Guid Id { get; }
        public DateTime Date { get; }
        public void Restore();
    }
}
