﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BootstrapDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Login()
        {
            return View();
        }
    }
}