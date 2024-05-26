using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4.Memento
{
    public class TextEditor : ITextEditor
    {
        private TextDocument _state;
        public TextEditor(TextDocument initialState)
        {
            this._state = initialState;
        }

        public IMemento Save()
        {
            return new Memento(this, new TextDocument(_state.Title, _state.Text));
        }

        public void SetState(TextDocument state)
        {
            this._state = state;
        }

        public override string ToString()
        {
            return $"Title: {_state.Title}, Text: {_state.Text}";
        }
    }
}
