using Microsoft.AspNetCore.Mvc;

namespace Emlak_UI.ViewComponents.AdminLayout
{
    public class _AdminLayoutNavbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        { return View(); }
    }
}
