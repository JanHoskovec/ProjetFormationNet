using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JeuDroides.Core.Models;


namespace DecouverteMvcNet.Controllers
{
    public class ParagrapheController : Controller
    {
        // GET: Paragraphe
        public ActionResult Index()
        {   
            Paragraphe paragraphe = new Paragraphe();
            paragraphe.Initialiser();
            this.ViewBag.MonParagraphe = paragraphe;
            return View();
        }
    }
}