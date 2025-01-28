using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class BigController : Controller
    {
        public IActionResult Index()
        {
            Company company = new Company {
                Name = "Best",
                Id = 01127587911,
            };
                
            Product product = new Product
            {
                Name = "Juice",
                Price = 35,
                Company = company
            };
            return View(product);
        }
    }
}
