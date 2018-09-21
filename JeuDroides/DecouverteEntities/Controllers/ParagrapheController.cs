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
                return View((from item in context.Paragraphe
                             orderby item.Numero
                             select item).ToList());
            }

        }
        public ActionResult Edit(int id) //obligatoire que le paramètre s'appelle pareil que celui spécifié dans le RouteConfig
        {
            using (JeuDroideEntities context = new JeuDroideEntities())
            {
                return View((from item in context.Paragraphe
                             where item.Id == id
                             select item).Single());
            }
        }

        // ne fonctionne pas
        [HttpPost]
        public ActionResult Edit(Paragraphe paragraphe)
        {
            using (JeuDroideEntities context = new JeuDroideEntities())
            {
                var requete = from para in context.Paragraphe
                              where para.Id == paragraphe.Id
                              select para;
                Paragraphe enCours = requete.Single();
                enCours.Contenu = paragraphe.Contenu;
                enCours.Numero = paragraphe.Numero;
                context.SaveChanges();
            }
            return this.View(paragraphe);
        }

        public ActionResult Ajouter()
        {
            return this.View(new Paragraphe());
        }
        
        [HttpPost]
        public ActionResult Ajouter(Paragraphe paragraphe)
        {
            using (JeuDroideEntities context = new JeuDroideEntities())
            {
                context.Paragraphe.Add(paragraphe);
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public ActionResult Supprimer(int id)
        {
            using (JeuDroideEntities context = new JeuDroideEntities())
            {
                return View((from item in context.Paragraphe
                             where item.Id == id
                             select item).Single());
            }
        }

        [HttpPost]
        public ActionResult Supprimer(Paragraphe paragraphe)
        {
            using (JeuDroideEntities context = new JeuDroideEntities())
            {
                context.Paragraphe.Remove((from para in context.Paragraphe
                                          where para.Id == paragraphe.Id
                                          select para).Single());
                context.SaveChanges();
            }
            
            return RedirectToAction("Index");
        }
        
    }
}