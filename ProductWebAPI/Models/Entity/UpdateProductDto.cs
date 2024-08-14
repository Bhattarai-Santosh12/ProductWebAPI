namespace ProductWebAPI.Models.Entity
{
    public class UpdateProductDto
    {
        public required string Name { get; set; }

        public string? Description { get; set; }

        public decimal Price { get; set; }

        public required int Quantity { get; set; }
    }
}
