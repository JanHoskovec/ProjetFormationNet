using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JeuDroides.Core.Models;

namespace ChallengeMvcNet.Controllers
{
    public class DroidController : Controller
    {
        // GET: Droid
        public ActionResult Index()
        {
            List<Droide> myDroides = Droide.GetAllM();
            ViewBag.Droids = myDroides;
            return View();
        }
    }
}