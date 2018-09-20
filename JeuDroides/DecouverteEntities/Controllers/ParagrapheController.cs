using DecouverteEntities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DecouverteEntities.Controllers
{
    public class ParagrapheController : Controller
    {
        // GET: Paragraphe
        public ActionResult Index()
        {
            using (JeuDroideEntities context = new JeuDroideEntities())
            {
                var requete = from para in context.Paragraphe
                              select para;

                return View(requete.ToList());
            }
        }

        public ActionResult Edit(int id) //obligatoire que le paramètre s'appelle pareil que celui spécifié dans le RouteConfig
        {
            using (JeuDroideEntities context = new JeuDroideEntities())
            {
                var requete = from para in context.Paragraphe
                              where para.Id == id
                              select para;
                
                return View(requete.Single()); // ou requete.First()
            }

                
        }

        [HttpPost]
        public ActionResult Edit(Paragraphe paragraphe)
        {
            return this.View();
        }
    }
}