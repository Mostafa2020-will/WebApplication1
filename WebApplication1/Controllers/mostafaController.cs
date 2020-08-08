using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class mostafaController : Controller
    {
        // GET: mostafa
        public ActionResult Index()
        {
            List<mostafa> xx = new List<mostafa>()
            {new mostafa(){id=1,name="ali",city="cairo",email="dodo_13@yahoo.com" },
            new mostafa(){id=2,name="hasan",city="cairo",email="fofo_13@yahoo.com" },
            new mostafa(){id=3,name="wael",city="cairo",email="koko_13@yahoo.com" },
            new mostafa(){id=4,name="tarik",city="cairo",email="dodo_13@yahoo.com" }


            };
            return View(xx);
        }
        public ActionResult Index2()
        {
            List<mostafa> pp = new List<mostafa>()
            {new mostafa(){id=1,name="llll",city="tanta",email="odo_13@yahoo.com" },
            new mostafa(){id=2,name="mmmm",city="cairo",email="ofo_13@yahoo.com" },
            new mostafa(){id=3,name="kkkkk",city="alex",email="oko_13@yahoo.com" },
            new mostafa(){id=4,name="sssss",city="cairo",email="odo_13@yahoo.com" }
            


            };
            return View(pp);
        }
    }
}