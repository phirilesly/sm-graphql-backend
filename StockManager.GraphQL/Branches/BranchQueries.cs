using MongoDB.Driver;
using StockManager.GraphQL.Data;
using StockManager.GraphQL.Models;

namespace StockManager.GraphQL.Branches

{
  

    [ExtendObjectType(Name = "Query")]
    public class BranchQueries
    {
        public async Task<List<Branch>> GetBranches([Service] MongoContext context) => context.Branches.FindSync(_ => true).ToList();

        public async Task<Branch> GetBranch([Service] MongoContext context, Guid id) => (await context.Branches.FindAsync(x => x.Id == id)).FirstOrDefault();
    }
}
