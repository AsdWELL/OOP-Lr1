using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lr1
{
    public abstract class StationFactory
    {
        public StationFactory() { }

        public abstract Station CreateStation();

        public abstract Station CreateStation(string title);

        public abstract Station CreateStation(string title, int numberOfSeats);

        public abstract Station CreateStation(string title, int numberOfSeats, int soldTickets,
            string number, double averageAttendace, DateTime dateOfOpening, string address);
    }
}
