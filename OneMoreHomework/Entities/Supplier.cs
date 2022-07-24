
using System.ComponentModel.DataAnnotations.Schema;

namespace OneMoreHomework.Entities
{
    [Table ("Suppliers")]
    public class Supplier
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SupplyingGoods {get;set;}
        public string Address { get; set; }
        public List<Product> Products { get; set; }
        
    }
}
