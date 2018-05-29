﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelperMethods.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Fruits = new string[] { "Яблоко", "Апельсин", "Груша" };
            ViewBag.Cities = new string[] { "Москва", "Лондон", "Париж" };

            string message = "Это HTML-элемент: <input>";

            return View((object)message);
        } // end Index()









    } // end class
} // end namespace