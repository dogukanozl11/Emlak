﻿using Microsoft.AspNetCore.Mvc;

namespace Emlak_UI.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
