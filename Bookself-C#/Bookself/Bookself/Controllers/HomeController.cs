﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bookself.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            // if logged in, redirect to Home/Discover
            // otherwise return Home/Index
            return View("Index");
        }


    }
}