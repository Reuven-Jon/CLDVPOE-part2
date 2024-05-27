using Microsoft.AspNetCore.Mvc;

namespace CLDVPOE_part2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
