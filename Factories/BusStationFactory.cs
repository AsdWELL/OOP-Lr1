using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lr1
{
    public class BusStationFactory : StationFactory
    {
        public BusStationFactory() : base() { }

        public override Station CreateStation()
        {
            return new BusStation();
        }

        public override Station CreateStation(string title)
        {
            return new BusStation(title);
        }

        public override Station CreateStation(string title, int numberOfSeats)
        {
            return new BusStation(title, numberOfSeats);
        }

        public override Station CreateStation(string title, int numberOfSeats, int soldTickets,
            string number, double averageAttendace, DateTime dateOfOpening, string address)
        {
            return new BusStation(title, numberOfSeats, soldTickets, number, averageAttendace, dateOfOpening, address);
        }
    }
}
