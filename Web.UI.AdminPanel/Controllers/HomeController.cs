﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.UI.AdminPanel.Controllers
{
    public class HomeController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
    }
}