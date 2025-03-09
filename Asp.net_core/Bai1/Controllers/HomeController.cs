using Microsoft.AspNetCore.Mvc;

namespace Bai1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GioiThieu()
        {
            return View();
        }
    }
}
