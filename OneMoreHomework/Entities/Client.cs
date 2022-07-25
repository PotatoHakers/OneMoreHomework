using System.ComponentModel.DataAnnotations.Schema;


namespace OneMoreHomework.Entities
{
    [Table ("CLients")]
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public List<Product> Products { get; set; }
        
    }
}
