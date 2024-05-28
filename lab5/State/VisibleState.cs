using lab5.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.State
{
    public class VisibleState: IVisibilityState
    {
        private LightElementNode context;
        public VisibleState(LightElementNode context)
        {
            this.context = context;
        }

        public void SetContext(LightElementNode context)
        {
            this.context = context;
        }
        public void Hide()
        {
            this.context.ChangeState(new HiddenState(context));
            Console.WriteLine($"{context.GetTagName()} is hidden now");
        }
        public void Show()
        {
            Console.WriteLine($"{context.GetTagName()} is shown already");
        }
    }
}
