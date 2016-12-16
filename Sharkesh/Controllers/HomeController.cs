using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sharkesh.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Home";
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Über Uns";

            return View();
        }
        public ActionResult Projects()
        {
            ViewBag.Message = "Projekte";
            return View();
        }
        public ActionResult Offers()
        {
            ViewBag.Message = "Angebote";
            return View();
        }
        public ActionResult Impressum()
        {
            ViewBag.Message = "Impressum";

            return View();
        }
        public ActionResult AGB()
        {
            ViewBag.Messsage = "AGB";
            return View();
        }
    }
}