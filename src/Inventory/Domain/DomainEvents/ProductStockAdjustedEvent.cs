namespace DomainEvents
{
    public class ProductStockAdjustedEvent
    {
        public object ProductId { get; private set; }
        public int QuantityAdjustment { get; private set; }
    }
}