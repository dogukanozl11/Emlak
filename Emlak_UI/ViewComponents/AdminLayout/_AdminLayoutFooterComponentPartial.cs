﻿using Microsoft.AspNetCore.Mvc;

namespace Emlak_UI.ViewComponents.AdminLayout
{
    public class _AdminLayoutFooterComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
