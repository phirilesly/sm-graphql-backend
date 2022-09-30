using System.ComponentModel.DataAnnotations;

namespace StockManager.GraphQL.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        [StringLength(4000)]
        public string Description { get; set; }
        [StringLength(4000)]
        public string Barcode { get; set; }
        [StringLength(4000)]
        public string Category { get; set; }
        [StringLength(4000)]
        public string SubCategory { get; set; }
        [StringLength(4000)]
        public string Brand { get; set; }
        [StringLength(4000)]
        public string Supplier { get; set; }
    }
}
