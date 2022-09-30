using StockManager.GraphQL.Common;
using StockManager.GraphQL.Models;

namespace StockManager.GraphQL.Categories
{
    public class CreateCategoryPayload: CategoryPayloadBase
    {
        public CreateCategoryPayload(Category category) : base(category)
        {
            Category = category;
        }

        public CreateCategoryPayload(IReadOnlyList<UserError> errors) : base(errors)
        {

        }
    }
}
