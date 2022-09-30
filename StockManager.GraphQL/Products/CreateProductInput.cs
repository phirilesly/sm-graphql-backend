namespace StockManager.GraphQL.Products
{
    

    public record CreateProductInput
    (
         string Name,
        string Description,
         string Barcode,
      string Category,
         string SubCategory,
         string Brand,
        string Supplier);
}
