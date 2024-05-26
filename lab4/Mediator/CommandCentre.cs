using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4.Mediator
{
    class CommandCentre
    {
        private List<Runway> _runways = new List<Runway>();
        private List<Aircraft> _aircrafts = new List<Aircraft>();

        public CommandCentre(Runway[] runways, Aircraft[] aircrafts)
        {
            foreach (Runway runway in runways)
            {
                runway.Mediator = this;
            }
            foreach (Aircraft aircraft in aircrafts)
            {
                aircraft.Mediator = this;
            }
            this._runways.AddRange(runways);
            this._aircrafts.AddRange(aircrafts);
        }
        public void InfoAboutAircrafts()
        {
            foreach(var aircraft in this._aircrafts)
            {
                Console.WriteLine($"Name: {aircraft.Name}, CurrentRunway: {aircraft.CurrentRunway}, IsTakingOff: {aircraft.IsTakingOff}");
            }
        }
        public void InfoAboutRunways()
        {
            foreach(var runway in this._runways)
            {
                Console.WriteLine($"Id: {runway.Id}, IsBusyWithAircraft: {runway.IsBusyWithAircraft}");
            }
        }
        private Runway? SearchRunway(Guid id)
        {
            var runway = _runways.FirstOrDefault(runway => runway.Id == id);
            if (runway == null)
            {
                Console.WriteLine($"There is no runway with id {id}");
                return null;
            }
            return runway;
        }
        public void CanLandingAircraft(Guid id, Aircraft aircraft)
        {
            var runway = SearchRunway(id);
            if (runway == null)
            {
                return;
            }

            if (runway.IsBusyWithAircraft == false)
            {
                Console.WriteLine($"Aircraft {aircraft.Name} has landed.");
                runway.IsBusyWithAircraft = true;
                runway.HighLightRed();
                aircraft.IsTakingOff = false;
                aircraft.CurrentRunway = runway.Id;
            }
            else
            {
                Console.WriteLine($"Could not land, the runway is busy.");
            }
        }
        public void MediatorTakeOff(Guid id, Aircraft aircraft)
        {
            var runway = SearchRunway(id);
            if (runway == null)
            {
                return;
            }
            runway.IsBusyWithAircraft = false;
            aircraft.IsTakingOff = true;
            aircraft.CurrentRunway = null;
            runway.HighLightGreen();
            Console.WriteLine($"Aircraft {aircraft.Name} has took off.");
        }
    }
}
