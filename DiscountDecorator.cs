using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lr1
{
    public class DiscountDecorator : Station
    {
        private double _ticketCost;
        public double Discount { get; set; }

        public DiscountDecorator(Station station, double discountInPersantage) : base(station)
        {
            _ticketCost = station.TicketCost;
            Discount = discountInPersantage;
        }

        public override double TicketCost
        {
            get => _ticketCost - (_ticketCost * Discount / 100);
        }
    }
}
