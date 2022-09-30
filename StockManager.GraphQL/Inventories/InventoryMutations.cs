using StockManager.GraphQL.Data;
using StockManager.GraphQL.Models;

namespace StockManager.GraphQL.Inventories
{


    [ExtendObjectType(Name = "Mutation")]
    public class InventoryMutations
    {
        public async Task<CreateInventoryPayload> CreateInventoryAsync(CreateInventoryInput input, [Service] MongoContext context)
        {
            var inventory = new Inventory
            {

                Id = Guid.NewGuid(),
                BranchId = input.BranchId,
                OrderDate = input.OrderDate,
                OrderItems = input.OrderItems,
                TotalPrice = input.TotalPrice,

            };
            await context.Inventories.InsertOneAsync(inventory);

            return new CreateInventoryPayload(inventory);

        }

    }
}
