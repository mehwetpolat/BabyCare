﻿using Microsoft.AspNetCore.Mvc;

namespace BabyCare.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
