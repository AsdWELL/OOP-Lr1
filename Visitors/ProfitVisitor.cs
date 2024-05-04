namespace Lr1
{
    public class ProfitVisitor : Visitor
    {
        public ProfitVisitor() : base() { }

        public double TotalProfit { get; private set; } = 0;

        public override void VisitStation(Station station)
        {
            int days = (int)(DateTime.Now - station.DateOfOpening).TotalDays;
            if (station.SoldTickets != null)
                TotalProfit = station.TicketCost * (int)station.SoldTickets * days;
        }
    }
}
