using Microsoft.AspNetCore.Mvc;

namespace Emlak_UI.Areas.EstateAgent.Controllers
{
    [Area("EstateAgent")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
