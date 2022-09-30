using StockManager.GraphQL.Common;
using StockManager.GraphQL.Models;

namespace StockManager.GraphQL.Sales
{
    public class CreateSalePayload: SalePayloadBase
    {
        public CreateSalePayload(Sale sale) : base(sale)
        {
            Sale= sale;
        }

        public CreateSalePayload(IReadOnlyList<UserError> errors) : base(errors)
        {

        }
    }
}
