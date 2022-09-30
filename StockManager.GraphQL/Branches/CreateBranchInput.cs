namespace StockManager.GraphQL.Branches
{
    public record CreateBranchInput
  (
        Guid Id,
           string Name,
            string Town,
            string Phone,
            string Address);
}
