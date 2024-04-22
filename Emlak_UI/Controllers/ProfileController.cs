using Microsoft.AspNetCore.Mvc;

namespace Emlak_UI.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
