using StockManager.GraphQL.Common;
using StockManager.GraphQL.Models;

namespace StockManager.GraphQL.Products
{
    public class CreateProductPayload: ProductPayloadBase
    {
        public CreateProductPayload(Product product): base(product)
        {
            Product = product;
        }

        public CreateProductPayload(IReadOnlyList<UserError> errors): base(errors)
        {

        }
     
    }
}
