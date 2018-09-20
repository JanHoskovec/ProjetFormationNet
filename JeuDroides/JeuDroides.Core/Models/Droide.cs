using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace JeuDroides.Core.Models
{
    public class Droide : Espece
    {
        public string Matricule { get; set; }
        public DateTime DateCreation { get; set; }
        public DateTime DerniereMiseAJour { get; set; }
        // TODO modeliser l'équipe de combat

        public static List<Droide> GetAllM ()
        {
            List<Droide> MyList = new List<Droide>();

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.MaChaineParDefautDeConnexion))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "select Nom from Droide where Nom like 'm%'";

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            Droide DroideEnCours = new Droide();
                            DroideEnCours.Nom = reader["Nom"].ToString();
                            MyList.Add(DroideEnCours);
                        }
                    }

                }
            }

            return MyList;
        }
    }
}
