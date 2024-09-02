using E_CommercePractice.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace E_CommercePractice.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        // For simplicity, let's just use a static list of products.
        private static List<Product> Products = new List<Product>
        {
            new Product { Id = 1, Name = "Product 1", Description = "This is product 1", Price = 9.99M },
            new Product { Id = 2, Name = "Product 2", Description = "This is product 2", Price = 19.99M },
        // Add more products as needed...
        };
        public IActionResult Index()
        {
            return View(Products);
        }
        public IActionResult Details(int id)
        {
            var product = Products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
