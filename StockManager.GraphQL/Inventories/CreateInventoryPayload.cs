using StockManager.GraphQL.Common;
using StockManager.GraphQL.Models;

namespace StockManager.GraphQL.Inventories
{
    public class CreateInventoryPayload : InventoryPayloadBase
    {
        public CreateInventoryPayload(Inventory inventory) : base(inventory)
        {
            Inventory = inventory;
        }

        public CreateInventoryPayload(IReadOnlyList<UserError> errors) : base(errors)
        {

        }
    }
}
