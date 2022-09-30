using StockManager.GraphQL.Common;
using StockManager.GraphQL.Models;

namespace StockManager.GraphQL.Products
{
    public class ProductPayloadBase: Payload
    {
        public ProductPayloadBase(Product product)
        {
            Product = product;
        }
        protected ProductPayloadBase(IReadOnlyList<UserError> errors): base(errors)
        {

        }
        public Product? Product { get; init; }
    }
}
