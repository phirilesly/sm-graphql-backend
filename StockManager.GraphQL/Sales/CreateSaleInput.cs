namespace StockManager.GraphQL.Sales
{
    public record CreateSaleInput
    (
        Guid ProductId,
         Guid BranchId,
        int Quantity,
        decimal Price
        );
}
