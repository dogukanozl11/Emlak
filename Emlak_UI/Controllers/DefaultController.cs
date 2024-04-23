using Microsoft.AspNetCore.Mvc;

namespace Emlak_UI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
