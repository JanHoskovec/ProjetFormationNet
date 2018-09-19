using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace DecouverteAdoNetBisExecuteNonQuery
{

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnectionServerDev))
                {
                    connection.Open();
                
                    Console.WriteLine("Veuillez choisir le type d'action :");
                    string[] actions = Enum.GetNames(typeof(TypeAction));
                    int[] values = (int[])Enum.GetValues(typeof(TypeAction));
                    for (int i = 0; i < actions.Length; i++)
                    {
                        Console.Write($"{values[i]} : {actions[i]}{(i == actions.Length - 1 ? ".\n" : ", ")}");
                    }
                    int action = ReadInteger();

                    switch ((TypeAction)action)
                    {
                        case TypeAction.Modify:
                            {
                                ModifyDroid(connection);
                            }
                            break;
                        case TypeAction.Delete:
                            {
                                DeleteDroid(connection);
                            }
                            break;
                        case TypeAction.Insert:
                            {
                                InsertDroid(connection);
                            }
                            break;
                        default:
                            Console.WriteLine("Commande non reconnue.");
                            break;
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Connexion à la base de données échouée.");
                Console.WriteLine(ex.Message + ", " + ex.StackTrace);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Une erreur s'est produite.");
            }
            finally
            { 
                Console.ReadLine();
            }

        }

        static void DeleteDroid(SqlConnection connection)
        {
            Console.WriteLine("Veuillez saisir l'Id du droïde à supprimer : ");
            int numDroid = ReadInteger();
            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "select Id from Droide where Id = " + numDroid;
                bool found = false;
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (!reader.HasRows)
                    {
                        Console.WriteLine($"Désolé, le droïde numéro {numDroid} n'a pas été retrouvée.");
                    }
                    else
                    {
                        found = true;
                    }
                }
                if (found)
                {
                    using (SqlCommand command2 = connection.CreateCommand())
                    {
                        command2.CommandText = "delete from Droide where Id = " + numDroid;
                        command2.ExecuteNonQuery();
                        Console.WriteLine("Suppression finie.");
                    }
                }
            }
        }

        static void ModifyDroid(SqlConnection connection)
        {
            
            Console.WriteLine($"Veuillez saisir l'Id du droïde à modifier (par défaut : {Properties.Settings.Default.DefaultId}) : ");
            int numDroid;
            if (!int.TryParse(Console.ReadLine(), out numDroid))
                numDroid = Properties.Settings.Default.DefaultId;
            //int numDroid = ReadInteger(); // Use the default value instead to test the setting file access
            Console.WriteLine("Veuillez saisir la nouvelle matricule : ");
            string matricule = Console.ReadLine();
            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "UPDATE[dbo].[Droide]" +
                    " SET[Matricule] = '" + matricule + "'" +
                    " ,[DateDerniereMiseAJour] = getdate()" +
                    " WHERE Id = " + numDroid;
                command.ExecuteNonQuery();
            }
            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "select" +
                    " Id, Nom, Matricule, DateDerniereMiseAJour" +
                    " from Droide" +
                    " where Id = " + numDroid;
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        Console.WriteLine("Voici le droïde modifié : ");
                        while (reader.Read())
                        {
                            Console.WriteLine("Id = " + reader["Id"]);
                            Console.WriteLine("Nom = " + reader["Nom"]);
                            Console.WriteLine("Matricule = " + reader["Matricule"]);
                            Console.WriteLine("Dernière mise à jour le " + reader["DateDerniereMiseAJour"]);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Désolé, votre droïde n'a pas pu être trouvé.");
                    }
                }
            }
        }

        static void InsertDroid(SqlConnection connection)
        {
            Console.WriteLine("Veuillez saisir le nom de votre nouveau droïde : ");
            string Name = Console.ReadLine();
            Console.WriteLine("Veuillez saisir la matricule de votre nouveau droïde : ");
            string Matricule = Console.ReadLine();
            List<int> Ids = new List<int>();
            List<string> Names = new List<string>();
            // Get names and IDs of combat teams
            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "select Nom, Id from EquipeId";
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if(reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Ids.Add(int.Parse(reader["Id"].ToString()));
                            Names.Add(reader["Nom"].ToString());
                        }
                    }
                }
            }
            Console.WriteLine("Veuillez saisir le numéro d'équipe de combat");
            Console.Write("(");
            for (int i = 0; i < Ids.Count; i++)
            {
                Console.Write($"{Ids[i]} : {Names[i]}");
                if (i < Ids.Count - 1)
                    Console.Write(", ");
            }
            Console.Write(")\n");
            // 
        }

        static int ReadInteger()
        {
            bool valid = false;
            int num = 0;
            while (!valid)
            {
                valid = int.TryParse(Console.ReadLine(), out num);
            }
            return num;
        }
    }
}
