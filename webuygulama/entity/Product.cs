using System.ComponentModel.DataAnnotations;

namespace webuygulama.entity
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
