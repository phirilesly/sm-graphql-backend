using StockManager.GraphQL.Common;
using StockManager.GraphQL.Models;

namespace StockManager.GraphQL.Branches
{
    public class BranchPayloadBase: Payload
    {
        public BranchPayloadBase(Branch branch)
        {
            Branch = branch;
        }
        protected BranchPayloadBase(IReadOnlyList<UserError> errors) : base(errors)
        {

        }
        public Branch? Branch { get; init; }
    }
}
