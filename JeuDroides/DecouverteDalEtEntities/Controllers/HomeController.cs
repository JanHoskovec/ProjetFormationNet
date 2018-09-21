using MaSuperLibrarie.Data_Layers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DecouverteDalEtEntities.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ParagrapheDataLayer layer = new ParagrapheDataLayer();
            return View(layer.GetAll());
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
    }
}