using lab5.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.Command
{
    public class ReplaceNodeCommand: ICommand
    {
        private LightElementNode _parent;
        private LightNode _oldNode;
        private LightNode _newNode;

        public ReplaceNodeCommand(LightElementNode parent, LightNode oldNode, LightNode newNode)
        {
            _parent = parent;
            _oldNode = oldNode;
            _newNode = newNode;
        }

        public void Execute()
        {
            int index = _parent.GetChildren().IndexOf(_oldNode);
            if (index != -1)
            {
                _parent.GetChildren()[index] = _newNode;
            }
        }

        public void Undo()
        {
            int index = _parent.GetChildren().IndexOf(_newNode);
            if (index != -1)
            {
                _parent.GetChildren()[index] = _oldNode;
            }
        }
    }
}
