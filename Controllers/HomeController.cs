using Microsoft.AspNetCore.Mvc;

namespace ese01.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}