using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace JeuDroides.Core.Models
{
    public class Paragraphe : Texte
    {
        public void Initialiser()
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString =
                    Properties.Settings.Default.MaChaineParDefautDeConnexion;
                connection.Open();

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText =
                        "select " +
                            "Paragraphe.Contenu as ContenuParagraph, " +
                            "Question.Contenu as ContenuQuestion," +
                            "Reponse.Contenu as ContenuReponse " +
                        "from Paragraphe " +
                        "join Question on Paragraphe.Id = Question.ParagraphId " +
                        "join Reponse on Question.Id = Reponse.QuestionId " +
                        "where Paragraphe.Id = 1";

                    using (var reader = command.ExecuteReader())
                    {
                        this.MaQuestion = new Question();
                        this.MaQuestion.MesReponses = new List<Reponse>();

                        while (reader.Read())
                        {
                            this.Contenu = reader["ContenuParagraph"].ToString();
                            this.MaQuestion.Contenu = reader["ContenuQuestion"].ToString();
                            Reponse reponse = new Reponse();
                            reponse.Contenu = reader["ContenuReponse"].ToString();
                            this.MaQuestion.MesReponses.Add(reponse);
                        }
                    }
                }
            }
        }

        public Question MaQuestion { get; set; }
    }
}