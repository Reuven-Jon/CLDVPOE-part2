using Microsoft.AspNetCore.Mvc;

namespace CLDVPOE_part2.Controllers
{
    public class AboutUsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
