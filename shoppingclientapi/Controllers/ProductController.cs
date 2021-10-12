using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MongoDB.Driver;
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
        private readonly ProductContext _context;

        public ProductController(ILogger<ProductController> logger, ProductContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await _context.Products.Find(item => true).ToListAsync();
        }
    }
}
