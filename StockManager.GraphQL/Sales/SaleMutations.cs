using StockManager.GraphQL.Data;
using StockManager.GraphQL.Models;

namespace StockManager.GraphQL.Sales
{


    [ExtendObjectType(Name = "Mutation")]
    public class SaleMutations
    {
        public async Task<CreateSalePayload> CreateSaleAsync(CreateSaleInput input, [Service] MongoContext context)
        {
            var sale = new Sale
            {

                Id = Guid.NewGuid(),
                BranchId = input.BranchId,
                Price = input.Price,
                ProductId = input.ProductId,
                Quantity = input.Quantity,

            };
            await context.Purchases.InsertOneAsync(sale);

            return new CreateSalePayload(sale);

        }

    }
    }
