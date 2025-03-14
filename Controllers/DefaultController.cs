﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        Context c= new Context();
        public ActionResult Index()
        {
            var degerler= c.Blogs.Take(4).ToList();
            return View(degerler);
        }
        public ActionResult About() 
        { 
            return View(); 
        }
        public ActionResult Contact()
        {
            return View();
        }
        public PartialViewResult Partial1() 
        {
            var degerler2 = c.Blogs.Take(10).ToList();
            return PartialView(degerler2);
        }
        public PartialViewResult Partial2() 
        {
            var degerler3 = c.Blogs.Take(3).ToList();
            return PartialView(degerler3);
        }
        public PartialViewResult Partial3() 
        { 
            var degerler= c.Blogs.Take(3).OrderByDescending(x => x.ID).ToList();
            return PartialView(degerler);
        }

    }
}