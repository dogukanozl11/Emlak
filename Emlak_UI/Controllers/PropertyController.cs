using Microsoft.AspNetCore.Mvc;

namespace Emlak_UI.Controllers
{
    public class PropertyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
