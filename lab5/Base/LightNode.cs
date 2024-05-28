using lab5.Iterator;
using lab5.Template_Method;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.Base
{
    public abstract class LightNode: LifecycleHooks
    {
        public abstract void OutterLightHTML();
        public abstract void ShortAbout();
    }
}
