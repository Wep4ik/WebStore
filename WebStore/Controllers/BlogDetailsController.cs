﻿using Microsoft.AspNetCore.Mvc;

namespace WebStore.Controllers
{
    public class BlogDetailsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
