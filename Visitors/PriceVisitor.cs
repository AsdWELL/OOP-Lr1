namespace Lr1
{
    public class PriceVisitor : Visitor
    {
        public PriceVisitor() : base() { }

        public double TotalPrice { get; set; }
        
        public override void VisitStation(Station station)
        {
            TotalPrice = station.TicketCost - (station.TicketCost / 100 * station.PercentageDiscount);
        }
    }
}
