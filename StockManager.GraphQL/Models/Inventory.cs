using StockManager.GraphQL.Inventories;

namespace StockManager.GraphQL.Models
{
    public class Inventory
    {

        public Guid Id { get; set; }
        public Guid BranchId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice { get; set; }
        public List<OrderItem> OrderItems { get; set; }
    }
}
