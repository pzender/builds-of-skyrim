﻿using BuildsOfSkyrim.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BuildsOfSkyrim.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Build()
        {
            return View(BuildDAO.Example());
        }
        
        public PartialViewResult Tree(int id)
        {
            return PartialView(SkillDAO.Example().PerksAvailable);
        }
    }
}