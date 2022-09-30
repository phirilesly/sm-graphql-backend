namespace StockManager.GraphQL.Brands
{
    public record CreateBrandInput
    (
           Guid Id,
        string Name,
        string Description);
}
