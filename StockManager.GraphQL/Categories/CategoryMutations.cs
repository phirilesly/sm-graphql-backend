using StockManager.GraphQL.Data;
using StockManager.GraphQL.Models;

namespace StockManager.GraphQL.Categories
{
    [ExtendObjectType(Name = "Mutation")]
    public class CategoryMutations
    {
        public async Task<CreateCategoryPayload> CreateCategoryAsync(CreateCategoryInput input, [Service] MongoContext context)
        {
            var category = new Category
            {

                Id = Guid.NewGuid(),
                Description = input.Description,
                Name = input.Name,

            };
            await context.Categories.InsertOneAsync(category);

            return new CreateCategoryPayload(category);

        }
    }
}
