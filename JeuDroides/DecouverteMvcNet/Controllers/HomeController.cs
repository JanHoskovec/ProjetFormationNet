using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DecouverteMvcNet.Controllers
{
    public class HomeController : Controller
    {
        private int _maValeur = 10;

        public ActionResult Index()
        {
            #region Exemples viewbags
            //this.ViewBag.DateEnCours = DateTime.Now.AddDays(3);

            //this._maValeur = this._maValeur + 3;

            //this.ViewBag.UneValeurAAfficher = this._maValeur;
            #endregion


           // int nbElements = 0;

            //using (SqlConnection connection = new SqlConnection())
            //{
            //    connection.ConnectionString = 
            //        Properties.Settings.Default.MaChaineParDefautDeConnexion;

            //    connection.Open();

            //    using (SqlCommand command = connection.CreateCommand())
            //    {
            //        command.CommandText = "select COUNT(Id) as NbDroides " +
            //                              "from Droide";

            //        this.ViewBag.NbDroides = command.ExecuteScalar();
            //    }
            //}
            

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            this._maValeur = this._maValeur + 2;

            this.ViewBag.UneValeurAAfficher = this._maValeur;

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}