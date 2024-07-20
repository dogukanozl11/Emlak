using Microsoft.AspNetCore.Mvc;

namespace Emlak_UI.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
