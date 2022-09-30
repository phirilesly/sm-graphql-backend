using MongoDB.Driver;
using StockManager.GraphQL.Data;
using StockManager.GraphQL.Models;

namespace StockManager.GraphQL.Categories
{
  

    [ExtendObjectType(Name = "Query")]
    public class CategoryQueries
    {
        public async Task<List<Category>> GetCategories([Service] MongoContext context) => context.Categories.FindSync(_ => true).ToList();

        public async Task<Category> GetCategory([Service] MongoContext context, Guid id) => (await context.Categories.FindAsync(x => x.Id == id)).FirstOrDefault();
    }
}
