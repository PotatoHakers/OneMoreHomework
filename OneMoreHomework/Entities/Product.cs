using OneMoreHomework.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace OneMoreHomework
{
    [Table ("Products")]
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        
        public List<Client> Client { get; set; }
        public Supplier? Supplier { get; set; }
        public List<ProductCategorycs> ProductCategorycs { get; set; }
        public Shop? Shop { get; set; }
    }
}
