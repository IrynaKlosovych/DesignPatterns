using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.Template_Method
{
    public abstract class LifecycleHooks
    {
        public void TemplateMethod()
        {
            OnCreated();
            OnInserted();
            OnStylesApplied();
            OnTextRendered();
            OnRemoved();
        }

        protected virtual void OnCreated() { }
        protected virtual void OnInserted() { }
        protected virtual void OnRemoved() { }
        protected virtual void OnStylesApplied() { }
        protected virtual void OnTextRendered() { }
    }
}
