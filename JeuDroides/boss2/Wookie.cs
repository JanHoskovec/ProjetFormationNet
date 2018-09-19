using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boss2
{
    public class Wookie : Personnage
    {
        public override void DisplayResume()
        {
            base.DisplayResume();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write($" et je suis un{(GetFemale() ? "e" : "")} wookie.\n");
            Console.ResetColor();
        }
    }
}
