using StockManager.GraphQL.Data;
using StockManager.GraphQL.Models;

namespace StockManager.GraphQL.Products
{
    [ExtendObjectType(Name = "Mutation")]
    public class ProductMutations
    {
        public async Task<CreateProductPayload> CreateProductAsync(CreateProductInput input, [Service] MongoContext context)
        {
            var product = new Product
            {
                Name = input.Name,
                Id = Guid.NewGuid(),
                Description = input.Description,
                SubCategory = input.SubCategory,
                Supplier = input.Supplier,
                Barcode = input.Barcode,
                Brand = input.Brand,
                Category = input.Category,
            };
            await context.Products.InsertOneAsync(product);

            return new CreateProductPayload(product);

        }
    }
}
