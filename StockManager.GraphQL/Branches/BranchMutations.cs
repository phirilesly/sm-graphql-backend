using StockManager.GraphQL.Data;
using StockManager.GraphQL.Models;

namespace StockManager.GraphQL.Branches
{


    [ExtendObjectType(Name = "Mutation")]
    public class BranchMutations
    {
        public async Task<CreateBranchPayload> CreateSaleAsync(CreateBranchInput input, [Service] MongoContext context)
        {
            var branch = new Branch
            {

                Id = Guid.NewGuid(),
                Name = input.Name,
                Address = input.Address,
                Phone = input.Phone,
                Town = input.Town,
            

            };
            await context.Branches.InsertOneAsync(branch);

            return new CreateBranchPayload(branch);

        }

    }
}
