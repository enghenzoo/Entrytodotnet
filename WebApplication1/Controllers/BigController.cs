using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Middlewares;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class BigController : Controller
    {

        public IActionResult Index()
        {
            var requestpath = CalcMiddleware.GetRequestPaths();
            return View(requestpath);
        }
    }
}
