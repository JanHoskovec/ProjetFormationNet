﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boss2
{
    public class Yoda : Personnage
    {
        public override void DisplayResume()
        {
            base.DisplayResume();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write($" et je suis un{(GetFemale() ? "e" : "")} yoda.\n");
            Console.ResetColor();
        }
    }
}
