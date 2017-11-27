namespace Domain
{
    public class Product : IStateContainer<ProductState>
    {
        private readonly string _name;
        private readonly string _description;
        private readonly Stock _productStock;
        private readonly string _notes;

        public ProductState GetCurrentState()
        {
            // Provide a way to get current state so that we can save state to the database and not the domain model.
            return new ProductState(_name, _description, _productStock, _notes);
        }
    }

    public class ProductState
    {
        public ProductState(string name, string description, Stock productStock, string notes) 
        {
            Name = name;
            Description = description;
            ProductStock = productStock;
            Notes = notes;
        }
        
        public string Name { get; private set; }
        public string Description { get; private set; }
        public Stock ProductStock { get; private set; }
        public string Notes { get; private set; }
    }
}