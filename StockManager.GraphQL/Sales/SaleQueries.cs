using StockManager.GraphQL.Data;
using StockManager.GraphQL.Models;
using MongoDB.Driver;

namespace StockManager.GraphQL.Sales
{


    [ExtendObjectType(Name = "Query")]
    public class SaleQueries
    {
        public async Task<List<Sale>> GetSales([Service] MongoContext context) => context.Purchases.FindSync(_ => true).ToList();

        public async Task<Sale> GetSale([Service] MongoContext context, Guid id) => (await context.Purchases.FindAsync(x => x.Id == id)).FirstOrDefault();
    }
}
