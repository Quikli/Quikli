namespace Domain.Commands
{
    public class RepriceProductCommand
    {
        public object ProductId { get; private set; }
        public decimal UpdatedPrice { get; private set; }
    }
}