﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyEcomerce.Controllers
{
    public class NovoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}