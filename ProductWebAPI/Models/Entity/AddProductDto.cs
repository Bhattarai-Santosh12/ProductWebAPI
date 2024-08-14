namespace ProductWebAPI.Models.Entity
{
    public class AddProductDto
    {
        public required string Name { get; set; }

        public string? Description { get; set; }

        public decimal Price { get; set; }

        public required int Quantity { get; set; }
    }
}
