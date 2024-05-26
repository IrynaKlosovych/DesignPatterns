using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4.Mediator
{
    class Aircraft: Base
    {
        public string Name { get; private set; }
        public Guid? CurrentRunway { get; set; }
        public bool IsTakingOff { get; set; }
        public Aircraft(string name, bool isTakingOff, Guid? id)
        {
            if (isTakingOff && id != null)
            {
                throw new InvalidOperationException("An aircraft that is taking off cannot have an assigned runway.");
            }
            this.Name = name;
            IsTakingOff = isTakingOff;
            this.CurrentRunway = id;
        }

        public void Land(Guid someId)
        {
            if(!IsTakingOff) {
                Console.WriteLine("Aircraft is not taking off");
                return;
            }
            Console.WriteLine($"Aircraft {this.Name} is landing.");
            Console.WriteLine($"Checking runway.");
            NotifyMediatorAboutLanding(someId);
        }

        protected void NotifyMediatorAboutLanding(Guid id)
        {
            if (this.Mediator != null)
            {
                this.Mediator.CanLandingAircraft(id, this);
            }
        }

        public void TakeOff()
        {
            if(IsTakingOff)
            {
                Console.WriteLine("Aircraft has already taken off");
                return;
            }
            if(CurrentRunway == null) {
                throw new Exception();
            }
            Console.WriteLine($"Aircraft {this.Name} is taking off.");
            NotifyMediatorAboutTakingOff((Guid)CurrentRunway);
        }
        protected void NotifyMediatorAboutTakingOff(Guid id)
        {
            if (this.Mediator != null)
            {
                this.Mediator.MediatorTakeOff(id, this);
            }
        }
    }
}
