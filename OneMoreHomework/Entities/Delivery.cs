
using System.ComponentModel.DataAnnotations.Schema;

namespace OneMoreHomework.Entities
{
    [Table ("Deliveryes")]
    public class Delivery
    {
        public int Id { get; set; }
        public string DeliveryType { get; set; }
        public string DateOf { get; set; }
        public string Status { get; set; }
        public List<Order> Orders { get; set; }

    }
}
