using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DecouverteSessions.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            this.Session["MaVariable"] = 10;
            return View();
        }

        public ActionResult About()
        {
            Session["MaVariable"] = (int)Session["MaVariable"] + 1;
            ViewBag.MaVariable = Session["MaVariable"];

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}