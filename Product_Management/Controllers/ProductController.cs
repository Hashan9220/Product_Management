using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Product_Management.Data;
using Product_Management.Models;
using Product_Management.Models.Domain;

namespace Product_Management.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductDbContext dbContext;

        public ProductController(ProductDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetAllProduct()
        {
           var product = dbContext.Products.ToList();
            return Ok(product);
        }
        [HttpPost]
        public IActionResult AddProduct(AddProductRequestDTO requestDTO)
        {
            var domainModelProduct = new Product
            {
                Id = Guid.NewGuid(),
                ProductCode = requestDTO.ProductCode,
                ProductName = requestDTO.ProductName,
                ProductCategory = requestDTO.ProductCategory,
                ProductQTY = requestDTO.ProductQTY
            };
            dbContext.Products.Add(domainModelProduct);
            dbContext.SaveChanges();

            return Ok(domainModelProduct);
        }
    }
}
