
using System.ComponentModel.DataAnnotations.Schema;

namespace OneMoreHomework.Entities
{
    [Table ("ProductCategorycs")]
    public class ProductCategorycs
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public List<Product> Products { get; set; }
        
    }
}
