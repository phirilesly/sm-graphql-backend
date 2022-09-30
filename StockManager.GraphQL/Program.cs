using StockManager.GraphQL.Branches;
using StockManager.GraphQL.Brands;
using StockManager.GraphQL.Categories;
using StockManager.GraphQL.Data;
using StockManager.GraphQL.Inventories;
using StockManager.GraphQL.Products;
using StockManager.GraphQL.Sales;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<MongoContext>();

// This adds the GraphQL server core service and declares a schema.
builder.Services
                   .AddGraphQLServer()
         .AddQueryType(d => d.Name("Query"))
              .AddTypeExtension<BranchQueries>()
         .AddTypeExtension<ProductQueries>()
           .AddTypeExtension<SaleQueries>()
            .AddTypeExtension<CategoryQueries>()
             .AddTypeExtension<BrandQueries>()
             .AddTypeExtension<InventoryQueries>()
             .AddMutationType(d => d.Name("Mutation"))
         .AddTypeExtension<ProductMutations>()
         .AddTypeExtension<BranchMutations>()
         .AddTypeExtension<InventoryMutations>()
         .AddTypeExtension<SaleMutations>()
         .AddTypeExtension<CategoryMutations>()
         .AddTypeExtension<BrandMutations>()
          .AddType(new UuidType('D'));
               

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.MapGraphQL();

app.Run();
