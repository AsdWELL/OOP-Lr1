using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lr1
{
    public class DiscountDecorator : Station
    {
        private Station _station;

        private double _discount;

        public DiscountDecorator(Station station, double discountInPersantage)
        {
            _station = station;
            _discount = discountInPersantage;
        }

        public override double TicketCost
        {
            get => _station.TicketCost - (_station.TicketCost * _discount / 100);
        }
    }
}
