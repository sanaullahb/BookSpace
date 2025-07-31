using Microsoft.AspNetCore.Mvc;

namespace BookSpace.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
