﻿using Microsoft.AspNetCore.Mvc;

namespace ES.Project.WEB.UI.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Detail()
        {
            return View();
        }
    }
}
