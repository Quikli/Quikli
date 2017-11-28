using System.Collections.Generic;

namespace Domain
{
    public class Inventory : IStateContainer<InventoryState>
    {
        private readonly string _name;
        private readonly List<Catalog> _catalogList;
        public InventoryState GetCurrentState()
        {
            return new InventoryState(_name, _catalogList);
        }
    }

    public class InventoryState
    {
        public InventoryState(string name, List<Catalog> catalogList)
        {
            Name = name;
            CatalogList = catalogList;
        }

        public object Name { get; private set; }
        public object CatalogList { get; private set; }
    }
}