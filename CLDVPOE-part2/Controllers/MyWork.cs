using Microsoft.AspNetCore.Mvc;


using System.Linq;

namespace CLDVPOE_part2.Controllers
{
    public class MyWorkController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MyWorkController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var products = _context.Products.ToList();
            return View(products);
        }

        public IActionResult AddToCart(int id)
        {
            var product = _context.Products.SingleOrDefault(p => p.ProductID == id);
            if (product == null)
            {
                return NotFound();
            }

            var cart = HttpContext.Session.GetObjectFromJson<List<Product>>("Cart") ?? new List<Product>();
            cart.Add(product);
            HttpContext.Session.SetObjectAsJson("Cart", cart);

            return RedirectToAction("Index");
        }
    }
}
