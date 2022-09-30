using StockManager.GraphQL.Common;
using StockManager.GraphQL.Models;

namespace StockManager.GraphQL.Brands
{
    public class BrandPayloadBase: Payload
    {
        public BrandPayloadBase(Brand product)
        {
            Brand = product;
        }
        protected BrandPayloadBase(IReadOnlyList<UserError> errors) : base(errors)
        {

        }
        public Brand? Brand { get; init; }
    }
}
