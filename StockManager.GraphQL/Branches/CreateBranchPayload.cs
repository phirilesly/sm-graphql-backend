using StockManager.GraphQL.Common;
using StockManager.GraphQL.Models;

namespace StockManager.GraphQL.Branches
{
    public class CreateBranchPayload: BranchPayloadBase
    {
        public CreateBranchPayload(Branch branch) : base(branch)
        {
            Branch = branch;
        }

        public CreateBranchPayload(IReadOnlyList<UserError> errors) : base(errors)
        {

        }
    }
}
