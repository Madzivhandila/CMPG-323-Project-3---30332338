using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using EcoPower_Logistics.Repository; // Import the Products Repository namespace

namespace EcoPower_Logistics.Controllers
{
    [Route("api/devices")]
    [ApiController]
    public class DevicesController : ControllerBase
    {
        private readonly ProductRepository productRepository; // Inject the Products Repository

        public DevicesController(ProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        [HttpGet("products/{productId}")]
        public ActionResult GetProduct(int productId)
        {
            try
            {
                var product = productRepository.GetProductById(productId);
                return Ok(product);
            }
            catch (InvalidOperationException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpGet("products")]
        public ActionResult<IEnumerable<Product>> GetProducts()
        {
            var products = productRepository.GetAllProducts();
            return Ok(products);
        }
    }
}
