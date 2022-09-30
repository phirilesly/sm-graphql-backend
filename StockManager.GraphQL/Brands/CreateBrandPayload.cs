using StockManager.GraphQL.Common;
using StockManager.GraphQL.Models;

namespace StockManager.GraphQL.Brands
{
    public class CreateBrandPayload: BrandPayloadBase
    {
        public CreateBrandPayload(Brand brand) : base(brand)
        {
            Brand = brand;
        }

        public CreateBrandPayload(IReadOnlyList<UserError> errors) : base(errors)
        {

        }
    }
}
