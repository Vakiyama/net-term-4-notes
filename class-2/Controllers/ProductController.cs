using Microsoft.AspNetCore.Mvc;

using class_2.Models;

namespace class_2.Data
{
    [Route("[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
       private readonly AppDbContext _context;

        // Inject the DbContext via constructor
        public ProductController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
          if (!_context.Products.Any())
            {
                var defaultProducts = new List<Product>
                {
                    new Product { Name = "Laptop", Price = 999.99m },
                    new Product { Name = "Smartphone", Price = 599.99m },
                    new Product { Name = "Tablet", Price = 299.99m }
                };

                _context.Products.AddRange(defaultProducts);
                _context.SaveChanges();
            }

            var products = _context.Products.ToList();

            ViewData["Products"] = products;

            return View();
        }

        [HttpGet("json")]
        public IActionResult GetProductsJson()
        {
            // Fetch products from the database
            var products = _context.Products.ToList();
            return Ok(products);
        }
    }
}

