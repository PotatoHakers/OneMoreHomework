
using System.ComponentModel.DataAnnotations.Schema;

namespace OneMoreHomework.Entities
{
    [Table ("Orders")]
    public class Order
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public string DateOf { get; set; }

        public Worker? Worker { get; set; }
        public Delivery? Delivery { get; set; }
        public int? DeliveryId { get; set; }
    }
}
