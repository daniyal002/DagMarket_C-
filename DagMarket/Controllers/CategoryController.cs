using Microsoft.AspNetCore.Mvc;

namespace DagMarket.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
