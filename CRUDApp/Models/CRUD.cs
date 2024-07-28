using System.ComponentModel.DataAnnotations;

namespace CRUDApp.Models
{
    public class CRUD
    {
        public int Id { get; set; }
        public string? Name { get; set; }
      
        public string? Quantity { get; set; }
        public string? Rating { get; set; }
        public decimal Price { get; set; }
    }
}
