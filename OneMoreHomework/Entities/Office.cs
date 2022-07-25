
using System.ComponentModel.DataAnnotations.Schema;

namespace OneMoreHomework.Entities
{
    [Table ("Offices")]
    public class Office
    {
        public int Id { get; set; }
        public int CountWorkers { get; set; }
        public string Address { get; set; }
        

        public List<Worker> Worker { get; set; }

    }
}
