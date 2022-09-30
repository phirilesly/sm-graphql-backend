using StockManager.GraphQL.Data;
using StockManager.GraphQL.Models;
using MongoDB.Driver;

namespace StockManager.GraphQL.Brands
{


    [ExtendObjectType(Name = "Query")]
    public class BrandQueries
    {
        public async Task<List<Brand>> GetBrands([Service] MongoContext context) => context.Brands.FindSync(_ => true).ToList();

        public async Task<Brand> GetBrand([Service] MongoContext context, Guid id) => (await context.Brands.FindAsync(x => x.Id == id)).FirstOrDefault();
    }
}
