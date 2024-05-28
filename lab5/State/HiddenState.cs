using lab5.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.State
{
    public class HiddenState: IVisibilityState
    {
        private LightElementNode context;
        public HiddenState(LightElementNode context)
        {
            this.context = context;
        }

        public void SetContext(LightElementNode context)
        {
            this.context = context;
        }
        public void Hide()
        {
            Console.WriteLine($"{context.GetTagName()} is hidden already");
        }
        public void Show()
        {
            this.context.ChangeState(new VisibleState(context));
            Console.WriteLine($"{context.GetTagName()} is shown now");
        }
    }
}
