using Microsoft.AspNetCore.Mvc;

namespace Emlak_UI.Areas.EstateAgent.Controllers
{
    public class MyAdvertsController : Controller
    {
        [Area("EstateAgent")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
