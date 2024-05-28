using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.Command
{
    public class Invoker
    {
        private ICommand edit;
        private ICommand replace;
        public Invoker(ICommand edit, ICommand replace) {
            this.edit = edit;
            this.replace = replace;
        }
        public void SetEdit(ICommand edit)
        {
            this.edit = edit;
        }

        public void SetReplace(ICommand replace)
        {
            this.replace = replace;
        }
        public void Editor()
        {
            this.edit.Execute();
        }
        public void Replacer()
        {
            this.replace.Execute();
        }
        public void EditorUndo()
        {
            this.edit.Undo();
        }
        public void ReplacerUndo()
        {
            this.replace.Undo();
        }
    }
}
