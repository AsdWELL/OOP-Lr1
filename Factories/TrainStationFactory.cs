using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lr1
{
    public class TrainStationFactory : StationFactory
    {
        public TrainStationFactory() : base() { }

        public override Station CreateStation()
        {
            return new TrainStation();
        }

        public override Station CreateStation(string title)
        {
            return new TrainStation(title);
        }

        public override Station CreateStation(string title, int numberOfSeats)
        {
            return new TrainStation(title, numberOfSeats);
        }

        public override Station CreateStation(string title, int numberOfSeats, int soldTickets,
            string number, double averageAttendace, DateTime dateOfOpening, string address)
        {
            return new TrainStation(title, numberOfSeats, soldTickets, number, averageAttendace, dateOfOpening, address);
        }
    }
}
