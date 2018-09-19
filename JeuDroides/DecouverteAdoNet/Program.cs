using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DecouverteAdoNet
{
    class Program
    {
        /// <summary>
        /// Affiche le paragraphe choisi depuis la base de données, avec la question et les réponses correspondantes.
        /// Ne fait rien si le numéro de paragraphe ne se trouve pas dans la BDD.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = @"Server=AJC344\SQLEXPRESS; Database=JeuDroide; Trusted_Connection=True;";
                connection.Open();

                #region corrige
                using (SqlCommand rameneParagraphes = connection.CreateCommand())
                {
                    rameneParagraphes.CommandText = "select" +
                        " Id, Numero" +
                        " from Paragraphe";
                    using (SqlDataReader readerParagraphes = rameneParagraphes.ExecuteReader())
                    {
                        Console.Write("Numéros de paragraphes disponibles : ");
                        while (readerParagraphes.Read())
                        {
                            Console.Write(readerParagraphes["Numero"] + " ");
                        }
                        Console.Write("\n");
                    }
                }
                #endregion

                Console.WriteLine("Veuillez saisir le numéro du paragraphe souhaité :");
                string ParagraphId = Console.ReadLine();

                #region corrige
                using (SqlCommand commandeUnParagraphe = connection.CreateCommand())
                {
                    commandeUnParagraphe.CommandText = "select Id from Paragraphe where Numero = " + ParagraphId;
                    decimal resultat = (decimal)commandeUnParagraphe.ExecuteScalar(); // 1 row + 1 col = use ExecuteScalar instead
                                                                                      // this was supposed to be obtained differently
                    #endregion

                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = "select" +
                            " Paragraphe.Numero as NoParagraph," +
                            " Paragraphe.Contenu as Paragraph," +
                            " Question.Contenu as Question," +
                            " Reponse.Contenu as Reponse" +
                            " from Paragraphe" +
                            " join Question on Question.ParagraphId = Paragraphe.Id" +
                            " join Reponse on Question.Id = Reponse.QuestionId" +
                            " where Paragraphe.Id = " + resultat;
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            int i = 0;
                            int current;
                            int previous = 0;
                            while (reader.Read())
                            {
                                current = int.Parse(reader["NoParagraph"].ToString());

                                if (previous != current)
                                {
                                    i = 0;
                                    previous = current;
                                    Console.WriteLine(reader["Paragraph"]);
                                    Console.WriteLine(reader["Question"]);
                                }
                                i++;
                                Console.WriteLine($"{i} : {reader["Reponse"]}");


                            }
                        }
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
