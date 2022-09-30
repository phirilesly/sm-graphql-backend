using MongoDB.Driver;
using StockManager.GraphQL.Data;
using StockManager.GraphQL.Models;

namespace StockManager.GraphQL.Inventories
{
 

[ExtendObjectType(Name = "Query")]
public class InventoryQueries
{
    public async Task<List<Inventory>> GetInventories([Service] MongoContext context) => context.Inventories.FindSync(_ => true).ToList();

    public async Task<Inventory> GetInventory([Service] MongoContext context, Guid id) => (await context.Inventories.FindAsync(x => x.Id == id)).FirstOrDefault();
}
}
