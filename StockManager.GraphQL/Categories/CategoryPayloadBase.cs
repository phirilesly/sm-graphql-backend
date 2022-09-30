using StockManager.GraphQL.Common;
using StockManager.GraphQL.Models;

namespace StockManager.GraphQL.Categories
{
    public class CategoryPayloadBase: Payload
    {
        public CategoryPayloadBase(Category category)
        {
            Category = category;
        }
        protected CategoryPayloadBase(IReadOnlyList<UserError> errors) : base(errors)
        {

        }
        public Category? Category { get; init; }
    }
}
