using Microsoft.AspNetCore.Mvc;

namespace MauiTestWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
} 