﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicHub.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public ActionResult Index()
        {
            //test
            return View();
        }
        //GET: Store/Product
        public ActionResult Product(String ProductName)
        {
            ViewBag.ProductName = ProductName;
            return View();
        }
    }
}