namespace StockManager.GraphQL.Inventories
{
    public record CreateInventoryInput
    (
        Guid Id,
        Guid BranchId,
        DateTime OrderDate,
         decimal TotalPrice,
         List<OrderItem> OrderItems
    );
}
