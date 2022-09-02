using StockManager.GraphQL;
using StockManager.GraphQL.Data;
using StockManager.GraphQL.Products;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<MongoContext>();
builder.Services
               .AddGraphQLServer()
               .AddQueryType(d => d.Name("Query"))
               .AddTypeExtension<ProductQueries>()
               .AddMutationType(d => d.Name("Mutation"))
               .AddTypeExtension<ProductMutations>();
               //.AddSubscriptionType(d => d.Name("Subscription"));

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
