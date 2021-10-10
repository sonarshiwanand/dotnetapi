using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using shoppingclientapi.Data;
using shoppingclientapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shoppingclientapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController
    {
        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Product> GetProducts()
        {
            return ProductContext.Products;
        }
    }
}
