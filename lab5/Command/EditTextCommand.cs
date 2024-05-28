using lab5.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.Command
{
    public class EditTextCommand: ICommand
    {
        private LightTextNode _textNode;
        private string _newText;
        private string _oldText;

        public EditTextCommand(LightTextNode textNode, string newText)
        {
            _textNode = textNode;
            _newText = newText;
            _oldText = textNode.text;
        }

        public void Execute()
        {
            _textNode.text = _newText;
        }

        public void Undo()
        {
            _textNode.text = _oldText;
        }
    }
}
