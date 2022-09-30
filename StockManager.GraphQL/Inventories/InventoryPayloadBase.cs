using StockManager.GraphQL.Common;
using StockManager.GraphQL.Models;

namespace StockManager.GraphQL.Inventories
{
    public class InventoryPayloadBase: Payload
    {
        public InventoryPayloadBase(Inventory inventory)
        {
            Inventory = inventory;
        }
        protected InventoryPayloadBase(IReadOnlyList<UserError> errors) : base(errors)
        {

        }
        public Inventory? Inventory { get; init; }
    }
}
