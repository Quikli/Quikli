namespace Domain.Commands
{
    public class ProductRestockedCommand
    {
        public object ProductId { get; private set; }
        public int NewStockQuantity { get; private set; }
    }
}