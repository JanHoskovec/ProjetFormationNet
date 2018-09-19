using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuDroides.Console.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            #region maVersion
            #region saisieUtilisateur
            #region saisieNom
            System.Console.WriteLine("Quel est le nom de votre personnage ?");
            string nomJedi = System.Console.ReadLine();
            System.Console.WriteLine($"Bonjour, {nomJedi.ToUpper()} !");
            
            #endregion
            #region saisieSexe
            string sexJedi = string.Empty;
            bool validInput = false;
            while (!validInput)
            {
                System.Console.WriteLine("Veuillez saisir le sexe de votre personnage (H pour homme, F pour femme)");
                sexJedi = System.Console.ReadLine();
                validInput = (sexJedi.ToUpper() == "F" || sexJedi.ToUpper() == "H");
                if (!validInput)
                {
                    System.Console.ForegroundColor = ConsoleColor.Red;
                    System.Console.WriteLine("Désolé, votre saisie n'est pas valide.");
                    System.Console.ResetColor();
                }
            }
            bool isFemale = (sexJedi.ToUpper() == "F"); 
            System.Console.WriteLine($"Votre personnage est donc {(isFemale ? "une femme" : "un homme")}.");
            #endregion


            #region saisieEspece
            System.Console.WriteLine("Une dernière question avant de commencer : quel est l'espèce de votre Jedi ?");

            //string[] especes = { (isFemale ? "humaine" : "humain"), "wookie", "yoda" };
            string[] especes = Enum.GetNames(typeof(TypeEspece));
            Array indexes = Enum.GetValues(typeof(TypeEspece));
            for (int i = 0; i < especes.Length; i++)
            {
                System.Console.Write($"{(int)indexes.GetValue(i) + 1} : {especes[i]}{(i == especes.Length - 1 ? ".\n" : ", ")}");
            }
            validInput = false;
            //string especeJedi = "";
            TypeEspece especeJedi;
            int indexEspece = -1;
            while (!validInput)
            {
                if (int.TryParse(System.Console.ReadLine(), out indexEspece))
                {
                    indexEspece--; // the user counts from 1, not 0
                    //validInput = (indexEspece >= 0) && (indexEspece < especes.Length);
                    validInput = Enum.IsDefined(typeof(TypeEspece), indexEspece);
                }
                if (!validInput)
                {
                    System.Console.ForegroundColor = ConsoleColor.Red;
                    System.Console.WriteLine("Désolé, votre saisie n'est pas valide.");
                    System.Console.ResetColor();
                }
            }
            //especeJedi = especes[indexEspece];
            especeJedi = (TypeEspece)indexEspece;
            System.Console.WriteLine($"D'accord, votre Jedi est un{(isFemale ? "e" : "")} {especeJedi}. Nous pouvons maintenant commencer le jeu.");
            #endregion




            System.Console.ReadLine();
            System.Console.Clear();
            #endregion

            string maChaine = "";
            maChaine = $"Il était une fois dans une galaxie lointaine... Très lointaine... Un{(isFemale ? "e" : "")} jeune Jedi, {nomJedi}, se prépare pour la guerre des clones.";

            System.Console.WriteLine(maChaine);
            System.Console.ReadLine();
            #endregion


            #region corrige
            /*        // this is redundant since it's already been initialized
                    //string maChaine = "";
                    //string 
                    nomJedi = "Rey";
                    maChaine = "Il était une fois dans une galaxie lointaine... Très lointaine... ";
                    string debut = "Un";*/
            //        string sexe = "M";

            //while((sexe != "H") && (sexe != "F"))
            //{
            //    System.Console.WriteLine("Quel est votre sexe ?");
            //    sexe = System.Console.ReadLine();
            //}
            //System.Console.ForegroundColor = ConsoleColor.Green;
            //if (sexe == "F")
            //{
            //    debut = debut + "e";
            //    System.Console.WriteLine("Vous avez bien saisi F.");
            //}
            //else
            //    System.Console.WriteLine("Vous avez bien saisi H.");
            //System.Console.ResetColor();
            /*      maChaine = maChaine + debut + " jeune Jedi : ";
                    maChaine = maChaine + nomJedi;
                    maChaine = maChaine + " se prépare pour la guerre des clones.";
                    System.Console.WriteLine(maChaine);
                    System.Console.ReadLine();*/



            //int[] monTableau = new int[10];
            //for (int i = 0; i < 10; i++)
            //{
            //    System.Console.WriteLine(i + "ème position : "+ monTableau[i]);
            //}



            #endregion

        }
    }
}
