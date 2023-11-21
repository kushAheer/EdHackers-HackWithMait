using Microsoft.AspNetCore.Mvc;

namespace EdTech.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
