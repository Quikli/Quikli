namespace Domain.Commands
{
    public class RemoveProductFromCatalogCommand
    {
        public object CatalogId { get; private set; }
        public object ProductId { get; private set; }
    }
}