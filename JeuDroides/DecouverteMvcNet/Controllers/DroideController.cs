using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DecouverteMvcNet.Controllers
{
    public class DroideController : Controller
    {
        // GET: Droide
        public ActionResult Index()
        {
            List<int> maListeEntiers = new List<int>();

            maListeEntiers.Add(12);
            maListeEntiers.Add(16);
            maListeEntiers.Add(200);

            this.ViewBag.MaListe = maListeEntiers;

            return View();
        }
    }
}