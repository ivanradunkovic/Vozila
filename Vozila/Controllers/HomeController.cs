using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Vozila.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult VehicleMake()
        {
            ViewBag.Message = "Your Vehicle Make";

            return View();
        }

        public ActionResult VehicleModel()
        {
            ViewBag.Message = "Your Vehicle Model";

            return View();
        }

        public ActionResult AboutAuthor()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}