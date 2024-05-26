using lab4.Observer.Events;
using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4.Observer
{
    public abstract class LightNode
    {
        private List<IEventListener> _subscribers = new List<IEventListener>();
        public abstract void OutterLightHTML();

        public void Subscribe(IEventListener subscriber)
        {
            this._subscribers.Add(subscriber);
        }
        public void Unsubscribe(IEventListener subscriber)
        {
            this._subscribers.Remove(subscriber);
        }

        private void _notify(IEventListener subscriber)
        {
            if(_subscribers.Contains(subscriber))
                subscriber.Update();
        }

        public void InvokeEvent(IEventListener subscriber)
        {
            this._notify(subscriber);
        }
    }
}
