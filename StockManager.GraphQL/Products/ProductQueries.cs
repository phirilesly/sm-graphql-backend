using StockManager.GraphQL.Data;
using StockManager.GraphQL.Models;
using MongoDB.Driver;


namespace StockManager.GraphQL.Products
{
    [ExtendObjectType(Name = "Query")]
    public class ProductQueries
    {
        public async Task<List<Product>> GetProducts([Service] MongoContext context) => context.Products.FindSync(_ => true).ToList();

        public async   Task<Product> GetProduct([Service] MongoContext context, Guid id) =>  (await context.Products.FindAsync(x => x.Id == id)).FirstOrDefault();
    }
}
