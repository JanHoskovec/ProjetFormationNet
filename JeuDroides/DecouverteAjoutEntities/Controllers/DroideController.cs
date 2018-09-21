using DecouverteAjoutEntities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DecouverteAjoutEntities.Controllers
{
    public class DroideController : Controller
    {
        // GET: Droide
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Ajouter()
        {
            return this.View(new Droide());
        }

        [HttpPost]
        public ActionResult Ajouter(Droide droide)
        {
            using (ContextEntities contexte = new ContextEntities())
            {
                contexte.Troide.Add(droide);
                contexte.SaveChanges();
            }

            return this.View(droide);
        }
    }
}