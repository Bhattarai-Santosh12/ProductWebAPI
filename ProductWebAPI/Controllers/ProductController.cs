using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductWebAPI.Data;
using ProductWebAPI.Models.Entity;

namespace ProductWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
      private readonly ApplicationDbContext dbContext;

        public ProductController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetAllProducts()
        {
            var products = dbContext.Products;
            return Ok(products);
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetProductById(int id)
        {
            var product = dbContext.Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        [HttpPost]
        public IActionResult AddProduct(AddProductDto addProductDto)
        {
            var ProductEntity = new product()
            {
                Name = addProductDto.Name,
                Description = addProductDto.Description,
                Price = addProductDto.Price,
                Quantity = addProductDto.Quantity,
            };

            dbContext.Products.Add(ProductEntity);
            dbContext.SaveChanges();
            return Ok(ProductEntity);
        }

        [HttpPut]
        [Route("{id:int}")]
        public IActionResult UpdateProduct(int id, UpdateProductDto updateProductDto)
        {
            var Product = dbContext.Products.Find(id);
            if (updateProductDto.Name == null)
            {
                return NotFound();
            }

            Product.Name = updateProductDto.Name;
                Product.Description = updateProductDto.Description;
                Product.Price = updateProductDto.Price;
                Product.Quantity = updateProductDto.Quantity;

            dbContext.SaveChanges();
            return Ok(Product);
            
        }

        [HttpDelete]
        [Route("{id:int}")]
        public IActionResult DeleteProduct(int id)
        {
            var product = dbContext.Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }

            dbContext.Products.Remove(product);
            dbContext.SaveChanges();
            return Ok(product);
        }



    }
}
