using StockManager.GraphQL.Data;
using StockManager.GraphQL.Models;

namespace StockManager.GraphQL.Brands
{
    [ExtendObjectType(Name = "Mutation")]
    public class BrandMutations
    {
        public async Task<CreateBrandPayload> CreateBrandAsync(CreateBrandInput input, [Service] MongoContext context)
        {
            var brand = new Brand
            {

                Id = Guid.NewGuid(),
               Description = input.Description,
               Name = input.Name,

            };
            await context.Brands.InsertOneAsync(brand);

            return new CreateBrandPayload(brand);

        }
    }
    }
