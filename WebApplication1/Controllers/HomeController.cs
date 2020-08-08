using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Index2()
        { 

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult products()
        {
            ViewBag.Message = "Your products page.";
            return View();
        }
        public ActionResult systema()
        {
            ViewBag.Message = "Your systema page.";
            return View();
        }
        public ActionResult employees()
        {
            ViewBag.Message = "Your employees page.";
            return View();
        }
    }
}