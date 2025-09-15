using Microsoft.AspNetCore.Mvc;

namespace ProgCMCS.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
