namespace StockManager.GraphQL.Models
{
    public class Branch
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Town { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }
    }
}
