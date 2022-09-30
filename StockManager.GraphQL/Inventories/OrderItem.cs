namespace StockManager.GraphQL.Inventories
{
    public record OrderItem
     (
         Guid OrderId,
        Guid ProductId,
         int Quantity,
         decimal OrderPrice,
         decimal TotalPrice
     );
}
