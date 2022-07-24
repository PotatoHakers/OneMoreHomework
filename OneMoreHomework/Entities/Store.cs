
using System.ComponentModel.DataAnnotations.Schema;

namespace OneMoreHomework.Entities
{
    [Table ("Stores")]
    public class Store : Shop
    {
        public string Square { get; set; }
        public string TypeStoredProduct { get; set; }
        
    }
}
