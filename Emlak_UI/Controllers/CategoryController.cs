using Microsoft.AspNetCore.Mvc;

namespace Emlak_UI.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
