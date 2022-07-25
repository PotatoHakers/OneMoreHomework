
using System.ComponentModel.DataAnnotations.Schema;

namespace OneMoreHomework.Entities
{
    [Table ("Shops")]
    public class Shop
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        
        public List<Product> Product { get; set; }
       
    }
}
