using lab3.Bridge.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3.Bridge.Shapes
{
    public abstract class Shape
    {
        protected ITypeDrawing _impl;
        public Shape(ITypeDrawing impl)
        {
            _impl = impl;
        }
        public abstract void Dwaw();
        public void SetImpl(ITypeDrawing impl)
        {
            _impl = impl;
        }
    }
}
