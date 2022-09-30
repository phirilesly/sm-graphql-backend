namespace StockManager.GraphQL.Categories
{
    public record CreateCategoryInput
   (
        Guid Id,
        string Name,
        string Description
        );
}
