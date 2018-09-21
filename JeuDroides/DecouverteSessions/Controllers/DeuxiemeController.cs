using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DecouverteSessions.Controllers
{
    public class DeuxiemeController : Controller
    {
        // GET: Deuxieme
        public ActionResult Index()
        {
            ViewBag.LaVar = (int)Session["MaVariable"] + 1;
            return View();
        }
    }
}