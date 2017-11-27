namespace Domain.Commands
{
    public class AddProductToCatalogCommand
    {
        public object CatalogId { get; private set; }
        public object ProductId { get; private set; }
    }
}