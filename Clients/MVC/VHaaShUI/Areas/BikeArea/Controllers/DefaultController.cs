﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VHaaSh.WEB.Areas.BikeArea.Controllers
{
    public class DefaultController : Controller
    {
        // GET: BikeArea/Default
        public ActionResult Index()
        {
            return View();
        }
    }
}