using StockManager.GraphQL.Common;
using StockManager.GraphQL.Models;

namespace StockManager.GraphQL.Sales
{
    public class SalePayloadBase: Payload
    {
        public SalePayloadBase(Sale sale)
        {
            Sale = sale;
        }
        protected SalePayloadBase(IReadOnlyList<UserError> errors) : base(errors)
        {

        }
        public Sale? Sale { get; init; }
    }
}
