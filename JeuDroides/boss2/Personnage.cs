using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boss2
{
    public class Personnage
    {
        

        private string nom = "";
        private bool isFemale = false;

        public void SetNom(string n)
        {
            this.nom = n;
        }

        public string GetNom()
        {
            return this.nom;
        }

        public void SetFemale(bool b)
        {
            this.isFemale = b;
        }

        public bool GetFemale()
        {
            return this.isFemale;
        }

        public virtual void DisplayResume()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write($"Bonjour, je m'appelle {this.nom}. Je suis {(this.isFemale ? "femelle" : "mâle")}");
            Console.ResetColor();
        }

    }
}
