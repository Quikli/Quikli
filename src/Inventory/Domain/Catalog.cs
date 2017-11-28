using System.Collections.Generic;

namespace Domain
{
    public class Catalog : IStateContainer<CatalogState>
    {
        private readonly string _name;

        private readonly List<Product> _productList;

        public CatalogState GetCurrentState()
        {
            return new CatalogState(_name, _productList);
        }
    }

    public class CatalogState
    {
        public CatalogState(string name, List<Product> productList)
        {
            Name        = name;
            ProductList = productList;
        }

        public string Name { get; private set; }
        public List<Product> ProductList { get; private set; }
    }
}