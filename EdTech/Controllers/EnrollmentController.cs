using Microsoft.AspNetCore.Mvc;

namespace EdTech.Controllers
{
    public class EnrollmentController : Controller
    {
        public IActionResult Index(int id)
        {

            return View();
        }
    }
}
