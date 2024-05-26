using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4.Memento
{
    public class Memento: IMemento
    {
        private readonly TextDocument _state;
        private TextEditor _originator;

        public Guid Id { get; } = Guid.NewGuid();
        public DateTime Date { get; } = DateTime.Now;

        public Memento(TextEditor originator, TextDocument state)
        {
            this._originator = originator;
            this._state = state;
        }

        public void Restore()
        {
            this._originator.SetState(this._state);
        }
    }
}
