using System.ComponentModel.DataAnnotations;

namespace ProductWebAPI.Models.Entity
{
    public class product
    {
        [Key]
        public int Id { get; set; }

        public required string Name { get; set; }    

        public string? Description { get; set; }

        public decimal Price { get; set; }

        public required int Quantity { get; set; }
    }
}
