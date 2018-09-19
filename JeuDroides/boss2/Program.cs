using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boss2
{
    class Program
    {
        static void Main(string[] args)
        {

            Personnage tempPersonnage = new Personnage();

            Console.WriteLine("Bienvenue dans le jeu !\nVeuillez saisir le nom de votre personnage.");
            tempPersonnage.SetNom(Console.ReadLine());
            Console.WriteLine($"Bonjour, {tempPersonnage.GetNom()} !");

            string sex = "";
            bool valid = false;
            while (!valid)
            {
                Console.WriteLine("Veuillez saisir le sexe de votre personnage (H pour homme, F pour femme)");
                sex = Console.ReadLine();
                valid = (sex.ToUpper() == "F" || sex.ToUpper() == "H");
                if (!valid) DisplayInputError();
            }
            tempPersonnage.SetFemale(sex.ToUpper() == "F");


            Console.WriteLine("Veuillez choisir l'espèce de votre personnage :");
            valid = false;
            string[] especes = Enum.GetNames(typeof(TypeEspece));
            int[] indexes = (int[])Enum.GetValues(typeof(TypeEspece));
            for (int i = 0; i < indexes.Length; i++)
            {
                Console.Write($"{indexes[i]} : {especes[i]}{(i == indexes.Length - 1 ? ".\n" : ", ")}");
            }
            int index = -1;
            while (!valid)
            {
                if (int.TryParse(Console.ReadLine(), out index))
                    valid = Enum.IsDefined(typeof(TypeEspece), index);
                if (!valid)
                    DisplayInputError();
            }

            
            Personnage finalPersonnage = FabricPersonnage.CreateOne(index);
            finalPersonnage.SetNom(tempPersonnage.GetNom());
            finalPersonnage.SetFemale(tempPersonnage.GetFemale());

            finalPersonnage.DisplayResume();

            // This is supposed to be loaded from the database.
            string question = $"Vous commencez votre aventure dans l’espace, à bord d’un vaisseau." +
                $" \nVotre vaisseau est destiné à arriver sur la planète Geonosis pour commencer les combats." +
                $"\n\nVous, {tempPersonnage.GetNom()} êtes un jedi débutant, c’est votre première bataille." +
                "\nUn Storm troopers à côté de vous, vous voit et vous demande:" +
                $"\n\n\tÇa va master {tempPersonnage.GetNom()}. Vous semblez inquiet ?!";

            Scene firstScene = new Scene(question);
            firstScene.AddAnswer("Non, un jedi n’a pas le droit d’être inquiet. Je vais bien, point c’est tout.");
            firstScene.AddAnswer("Un peu oui, c’est mon premier jour en tant que Jedi. Merci.");

            firstScene.Display();
            int answer = firstScene.GetAnswer();
            // This will then be stored with a timestamp in the database.


            Console.ReadLine();
        }

        public static void DisplayInputError()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Désolé, votre saisie n'est pas valide");
            Console.ResetColor();
        }


    }
}
