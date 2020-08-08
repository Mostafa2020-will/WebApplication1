using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class accountController : Controller
    {
        // GET: account
        public ViewResult  Index2()
        {
            return View () ;
        }
        public FileResult Index3()
        {
            return File(Server.MapPath("~/Content/ m abdlhakem C.V.19.11.2018doc"),"txt/doc","cv.doc");
        }
        public JsonResult Index4()
        {
            List<Models.mostafa> list = new List<Models.mostafa>()
            {new Models.mostafa() {id=1,name="ali",city="cairo",email="ahmed_20@yahoo.com" }, 
            new Models.mostafa() { id = 2, name = "omar", city = "cairo",email="mosr_20@yahoo.com" },
            new Models.mostafa() { id = 3, name = "jalal", city = "cairo",email="polo_20@yahoo.com" },
            new Models.mostafa() { id = 4, name = "hamad", city = "alxandria",email="tako_20@yahoo.com" }
            };
            return Json(list,JsonRequestBehavior.AllowGet);
        }
    }
}